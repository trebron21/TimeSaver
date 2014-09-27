using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * Planned features:
 *      - append a task with start and end time, without waiting for the time to elapse
 *      - deleting a task from the list: needs a button and an option to select from the listelements
 *      - loading saved list from file
 *      - sort the table with columnclicks
 *      not necessary after sorting is done - colouring different tasks
 *      done - notification on saving of a running task
 *      done - statistics: e.g. sum of worktask hours and sum of non-worktasks
 */

namespace JustinTime
{
    public partial class frmMain : Form
    {
        private MyTask activeTask;
        protected static List<MyTask> taskList = new List<MyTask>();

        protected class TaskStats
        {
            public TaskStats()
            {
                m_workTasks = m_nonWorkTasks = TimeSpan.Zero;
            }

            public List<TimeSpan> updateStatistics()
            {
                m_workTasks = m_nonWorkTasks = TimeSpan.Zero;

                foreach ( MyTask tsk in taskList )
                {
                        if ( tsk.IsWorking ) // if it is workrelated task
                        {
                            if ( tsk.End != tsk.Start ) // if the tasks isn't finished yet, we can use "Now" as "End" time
                                m_workTasks = m_workTasks.Add(tsk.End - tsk.Start);
                            else
                                m_workTasks = m_workTasks.Add(DateTime.Now - tsk.Start);
                        }
                        else // if nonworkrelated task, e.g. coffeebreak
                        {
                            if ( tsk.End != tsk.Start )
                                m_nonWorkTasks = m_nonWorkTasks.Add(tsk.End - tsk.Start);
                            else
                                m_nonWorkTasks = m_nonWorkTasks.Add(DateTime.Now - tsk.Start);
                        }
                }

                List<TimeSpan> ret = new List<TimeSpan>();
                ret.Add(m_workTasks);
                ret.Add(m_nonWorkTasks);

                return ret;
            }

            private TimeSpan m_workTasks;
            private TimeSpan m_nonWorkTasks;
        };

        private static TaskStats m_taskStats = new TaskStats();

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtTaskInput_Click(object sender, EventArgs e)
        {
            txtTaskInput.Text = "";
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            btnStart.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtTaskInput.Text.Length == 0)
            {
                MessageBox.Show("Please give a name to your task!");
                return;
            }

            if (btnStop.Enabled)
                btnStop_Click(this, e);

            MyTask newTask = new MyTask();
            newTask.Description = txtTaskInput.Text;
            newTask.Start = DateTime.Now;
            newTask.End = newTask.Start;
            newTask.IsWorking = chBIsWorking.Checked;

            stsLblInfo.Text = "Task \"" + newTask.Description.ToString() + "\" started at " + newTask.Start.ToString("hh\\:mm\\:ss");
            btnStop.Enabled = true;

            activeTask = newTask;

            updateList();
        }

        private void txtTaskInput_KeyUp(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
            {
                btnStart_Click(this, e);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // TODO: Stop is only allowed to do something, if there is a running task
            // maybe it is solved, because this click is only able to work, if the button is enabled
            // but: try to find out, if the calls of this function are working, even though the button is disabled
            activeTask.End = DateTime.Now;
            taskList.Add(activeTask);

            btnStop.Enabled = false;

            //stsLblInfo.Text = "You're cool! You've just finished the task \"" + activeTask.description.ToString() + "\" at " + activeTask.end.ToString();
            stsLblInfo.Text = "Task is done: \"" + taskList.Last().Description.ToString() + "\"";

            List<TimeSpan> lstStats = m_taskStats.updateStatistics();
            stsLblStats.Text = "WorkTasks = " + lstStats.ElementAt(0).ToString("hh\\:mm\\:ss\\.ff") + " | NonWorkTasks = " + lstStats.ElementAt(1).ToString("hh\\:mm\\:ss\\.ff");
            updateList();
        }

        private void updateList() 
        {
            foreach ( ListViewItem lvi in lstView.Items )
            {
                lvi.Remove();
            }

            foreach ( MyTask task in taskList )
            {
                ListViewItem item = new ListViewItem(task.Description);

                item.SubItems.Add(task.Start.ToString("hh\\:mm\\:ss"));
                item.SubItems.Add(task.End.ToString("hh\\:mm\\:ss"));
                item.SubItems.Add((task.End - task.Start).ToString("hh\\:mm\\:ss\\.ff"));

                //Add the items to the ListView.
                lstView.Items.AddRange(new ListViewItem[] { item });
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if ( btnStop.Enabled )
                    btnStop_Click(this, e);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnStop.Enabled)
            {
                var msgResult = MessageBox.Show("You're in the midst of a task and if you leave it running, it will not be saved by the app. \nDo you want to interrupt the task?", "Saving...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (msgResult == DialogResult.Yes)
                    btnStop_Click(this, e);
                else if (msgResult == DialogResult.Cancel)
                    return;
            }

            Stream myStream;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if ( (myStream = sfd.OpenFile()) != null )
                {
                    StreamWriter myStrWriter = new StreamWriter(myStream);

                    // Filling the file with the list of tasks
                    foreach (MyTask tsk in taskList)
                    {
                        try
                        {
                            myStrWriter.WriteLine(tsk.Description + ";" + tsk.Start.ToString() + ";" + tsk.End.ToString() + ";" + tsk.IsWorking.ToString());
                        }
                        catch (IOException ie)
                        {
                            stsLblInfo.Text = ie.GetType().Name + ": The write operation could not be performed, because the file is locked.";
                        }
                    }

                    myStrWriter.Flush();
                    myStream.Close();
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dlgRslt = MessageBox.Show("Do you want to save your tasks before leaving the app?", "Saving your tasks into a file!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dlgRslt == DialogResult.Yes)
                btnSave_Click(this, e);
            else if (dlgRslt == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void lstView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            lstView.Sort();
        }
    }

    public class MyTask
    {
        public MyTask()
        {
            m_isWorking = false;
        }

        public string Description {
                                      get { return m_description; }
                                      set { m_description = value; }
                                  }
        public DateTime Start {
                                  get { return m_start; }
                                  set { m_start = value; }
                              }
        public DateTime End {
                                get { return m_end; }
                                set { m_end = value; }
                            }
        public bool IsWorking {
                                  get { return m_isWorking; }
                                  set { m_isWorking = value; }
                              }

        private string m_description;
        private DateTime m_start;
        private DateTime m_end;
        private bool m_isWorking;
    };

}
