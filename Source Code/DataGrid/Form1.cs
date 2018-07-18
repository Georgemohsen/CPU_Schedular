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

namespace CPU_Schedular
{
    public partial class Form1 : Form
    {
        List<Process> readyProcess = new List<Process>();
        int quantum;
        int rows;
        double averageFCFS = 0;
        double averageSJF = 0;
        double averageSJFP = 0;
        double averageRR = 0;
        double averagePRIO = 0;
        private void Sort_According_to_Priority()
        {
            fillTheList();
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (readyProcess[i].Priority > readyProcess[j].Priority)
                    {
                        int temp = readyProcess[i].Priority;
                        readyProcess[i].Priority = readyProcess[j].Priority;
                        readyProcess[j].Priority = temp;
                        int temp1 = readyProcess[i].ProcessID;
                        readyProcess[i].ProcessID = readyProcess[j].ProcessID;
                        readyProcess[j].ProcessID = temp1;
                        int temp2 = readyProcess[i].BurstTime;
                        readyProcess[i].BurstTime = readyProcess[j].BurstTime;
                        readyProcess[j].BurstTime = temp2;
                        int temp3 = (int)readyProcess[i].WaitingTime;
                        readyProcess[i].WaitingTime = readyProcess[j].WaitingTime;
                        readyProcess[j].WaitingTime = temp3;
                    }
                }
            }
        }
        private void Sort_According_to_Arrival_time()
        {
            fillTheList();
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (readyProcess[i].ArrivedTime > readyProcess[j].ArrivedTime)
                    {
                        int temp = readyProcess[i].ArrivedTime;
                        readyProcess[i].ArrivedTime = readyProcess[j].ArrivedTime;
                        readyProcess[j].ArrivedTime = temp;
                        int temp1 = readyProcess[i].ProcessID;
                        readyProcess[i].ProcessID = readyProcess[j].ProcessID;
                        readyProcess[j].ProcessID = temp1;
                        int temp2 = readyProcess[i].BurstTime;
                        readyProcess[i].BurstTime = readyProcess[j].BurstTime;
                        readyProcess[j].BurstTime = temp2;
                        int temp3 = readyProcess[i].Priority;
                        readyProcess[i].Priority = readyProcess[j].Priority;
                        readyProcess[j].Priority = temp3;
                        int temp4 = (int)readyProcess[i].WaitingTime;
                        readyProcess[i].WaitingTime = readyProcess[j].WaitingTime;
                        readyProcess[j].WaitingTime = temp4;
                    }
                }
            }
        }
        private void Sort_According_to_BurstTime()
        {
            fillTheList();
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (readyProcess[i].BurstTime > readyProcess[j].BurstTime)
                    {
                        int temp = readyProcess[i].BurstTime;
                        readyProcess[i].BurstTime = readyProcess[j].BurstTime;
                        readyProcess[j].BurstTime = temp;
                        int temp1 = readyProcess[i].ProcessID;
                        readyProcess[i].ProcessID = readyProcess[j].ProcessID;
                        readyProcess[j].ProcessID = temp1;
                        int temp2 = readyProcess[i].ArrivedTime;
                        readyProcess[i].ArrivedTime = readyProcess[j].ArrivedTime;
                        readyProcess[j].ArrivedTime = temp2;
                        int temp3 = (int)readyProcess[i].WaitingTime;
                        readyProcess[i].WaitingTime = readyProcess[j].WaitingTime;
                        readyProcess[j].WaitingTime = temp3;
                    }
                }
            }
        }
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Burst Time", typeof(int));
            table.Columns.Add("Arrival Time", typeof(int));
            table.Columns.Add("Priority", typeof(int));
            table.Columns.Add("Waiting Time", typeof(int));
            dataGridView1.DataSource = table;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Priority_NonPreemptive()
        {
            bool flag = false;
            fillTheList();
            for (int i = 0; i < rows; i++)
            {
                if (readyProcess[i].ArrivedTime != 0)
                {
                    flag = true;
                }
                break;
            }
            if (flag == false)
            {
                Sort_According_to_Priority();
                string x;
                double sum = 0;
                readyProcess[0].WaitingTime = 0;
                for (int i = 1; i < rows; i++)
                {
                    readyProcess[i].WaitingTime = 0;
                    for (int j = 0; j < i; j++)
                    {
                        readyProcess[i].WaitingTime += readyProcess[j].BurstTime;
                    }
                    x = "P" + readyProcess[i - 1].ProcessID;
                    textBox2.Text += x + "  ";
                }
                textBox2.Text += "P" + readyProcess[rows - 1].ProcessID;
                for (int i = 0; i < rows; i++)
                {
                    dataGridView1["Waiting Time", i].Value = readyProcess[i].WaitingTime;
                }
                for (int i = 1; i < rows; i++)
                {
                    sum += readyProcess[i].WaitingTime;
                }
                averagePRIO = sum / rows;
            }
        }
        private void RoundRobin()
        {
            fillTheList();
            string x=null;
            int time;
            int count;
            int remain=rows;
            int flag=0;
            double wait_time=0;
            double sum = 0;
            List<int> remBurstTime = new List<int>();
            for (int i = 0; i < rows; i++)
            {
                remBurstTime.Add(readyProcess[i].BurstTime);
            }
            for (time = 0, count = 0; remain != 0; )
            {
                if (remBurstTime[count] <= quantum && remBurstTime[count] > 0)
                {
                    time += remBurstTime[count];
                    remBurstTime[count] = 0;
                    flag = 1;
                    x += "P" + readyProcess[count].ProcessID + "  ";
                    textBox2.Text = x;
                }
                else if (remBurstTime[count]>0)
                {
                    remBurstTime[count] -= quantum;
                    time += quantum;
                    x += "P" + readyProcess[count].ProcessID + "  ";
                    textBox2.Text = x;
                }
                if (remBurstTime[count] == 0 && flag == 1)
                {
                    remain--;
                    readyProcess[count].WaitingTime = time - readyProcess[count].BurstTime - readyProcess[count].ArrivedTime;
                    wait_time += readyProcess[count].WaitingTime = time - readyProcess[count].BurstTime - readyProcess[count].ArrivedTime;
                    flag = 0;
                }
                if (count == rows - 1)
                    count = 0;
                else if (readyProcess[count + 1].ArrivedTime <= time)
                    count++;
                else
                    count = 0;
                
            }
            for (int i = 0; i < rows; i++)
            {
                dataGridView1["Waiting Time", i].Value = readyProcess[i].WaitingTime;
            }
            averageRR = wait_time / rows;
        }  
        private void SJB_NonPreemptive()
        {
            fillTheList();
            bool flag = false;
            for (int i = 0; i < rows; i++)
            {
                if (readyProcess[i].ArrivedTime != 0)
                {
                    flag = true;
                }
                if (flag == true)
                    break;
            }
            if (flag == false)
            {
                string x;
                Sort_According_to_BurstTime();
                double sum = 0;
                readyProcess[0].WaitingTime = 0;
                for (int i = 1; i < rows; i++)
                {
                    readyProcess[i].WaitingTime = 0;
                    for (int j = 0; j < i; j++)
                    {
                        readyProcess[i].WaitingTime += readyProcess[j].BurstTime;
                    }
                    x = "P" + readyProcess[i - 1].ProcessID;
                    textBox2.Text += x + "  ";
                }
                textBox2.Text += "P" + readyProcess[rows - 1].ProcessID;
                for (int i = 1; i < rows; i++)
                {
                    sum += readyProcess[i].WaitingTime;
                }

                for (int i = 0; i < rows; i++)
                {
                    dataGridView1["Waiting Time", i].Value = readyProcess[i].WaitingTime;
                }
                averageSJF = sum / rows;
            }
            else
            {
                double sum = 0;
                Sort_According_to_Arrival_time();
                readyProcess[0].WaitingTime = 0;
                for (int i = 1; i < rows - 1; i++)
                {
                    for (int j = i + 1; j < rows; j++)
                    {
                        if (readyProcess[i].BurstTime > readyProcess[j].BurstTime)
                        {
                            int temp = readyProcess[i].BurstTime;
                            readyProcess[i].BurstTime = readyProcess[j].BurstTime;
                            readyProcess[j].BurstTime = temp;
                            int temp1 = readyProcess[i].ProcessID;
                            readyProcess[i].ProcessID = readyProcess[j].ProcessID;
                            readyProcess[j].ProcessID = temp1;
                            int temp2 = readyProcess[i].ArrivedTime;
                            readyProcess[i].ArrivedTime = readyProcess[j].ArrivedTime;
                            readyProcess[j].ArrivedTime = temp2;
                            int temp3 = (int)readyProcess[i].WaitingTime;
                            readyProcess[i].WaitingTime = readyProcess[j].WaitingTime;
                            readyProcess[j].WaitingTime = temp3;
                        }
                    }
                }
                string x=null;
                int sumOfBurst = 0; ;
                readyProcess[0].WaitingTime = 0;
                dataGridView1["Waiting Time", 0].Value = readyProcess[0].WaitingTime;
                x += "P" + readyProcess[0].ProcessID+"  ";
                for (int i = 1; i < rows; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sumOfBurst += readyProcess[j].BurstTime;
                    }
                    readyProcess[i].WaitingTime = sumOfBurst - readyProcess[i].ArrivedTime;
                    dataGridView1["Waiting Time", i].Value = readyProcess[i].WaitingTime;
                    sumOfBurst = 0;
                    x += "P" + readyProcess[i].ProcessID + "  ";
                    textBox2.Text = x;
                }
                for (int i = 0; i < rows; i++)
                {
                    sum += readyProcess[i].WaitingTime;
                }
                averageSJF = sum / rows;
            }
        } 
        private void SJB_Preemptive()
        {
            fillTheList();
            List<int> burstTime = new List<int>();
            int complete = 0, t = 0, min = int.MaxValue;
            int shortest = 0, finishTime = 0; ;
            bool check = false;
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                burstTime.Add(readyProcess[i].BurstTime);
            }
            while (complete != rows)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (readyProcess[j].ArrivedTime <= t && burstTime[j] < min && burstTime[j] > 0)
                    {
                        min = burstTime[j];
                        shortest = j;
                        check = true;
                    }
                }
                if (check == false)
                {
                    t++;
                    continue;
                }
                burstTime[shortest]--;
                min = burstTime[shortest];
                if (min == 0)
                    min = int.MaxValue;
                if (burstTime[shortest] == 0)
                {
                    complete++;
                    finishTime = t + 1;
                    readyProcess[shortest].WaitingTime = finishTime - readyProcess[shortest].BurstTime - readyProcess[shortest].ArrivedTime;
                    if (readyProcess[shortest].WaitingTime < 0)
                        readyProcess[shortest].WaitingTime = 0;
                    dataGridView1["Waiting Time", shortest].Value = readyProcess[shortest].WaitingTime;
                }
                t++;
            }
            for (int i = 0; i < rows; i++)
            {
                sum += readyProcess[i].WaitingTime;
            }
            averageSJFP = sum / rows;
        }
        private void FCFS()
        {
            fillTheList();
            double sum = 0;
            string x;
            readyProcess[0].WaitingTime = 0;
            for (int i = 1; i < rows; i++)
            {
                readyProcess[i].WaitingTime = 0;
                for (int j = 0; j < i; j++)
                {
                    readyProcess[i].WaitingTime += readyProcess[j].BurstTime;
                }
                readyProcess[i].WaitingTime = readyProcess[i].WaitingTime - readyProcess[i].ArrivedTime;
                x = "P" + i;
                textBox2.Text += x + "  ";
            }
            textBox2.Text += "P" + rows;
            for (int i = 1; i < rows; i++)
            {
                sum += readyProcess[i].WaitingTime;
            }
            for (int i = 0; i < rows; i++)
            {
                dataGridView1["Waiting Time", i].Value = readyProcess[i].WaitingTime;
            }
            averageFCFS = sum / rows;
        } 
        private void fillTheList()
        {
            int numberOfProcess = rows;
            for (int i = 0; i < numberOfProcess; i++)
            {
                readyProcess.Add(new Process
                {
                    ProcessID = Convert.ToInt32(dataGridView1["ID", i].Value),
                    BurstTime = Convert.ToInt32(dataGridView1["Burst Time", i].Value),
                    ArrivedTime = Convert.ToInt32(dataGridView1["Arrival Time", i].Value),
                    Priority = Convert.ToInt32(dataGridView1["Priority", i].Value)
                });
            }
        }
        // getting the input from File 
        private void readFile()
        {
            table.AcceptChanges();
            foreach (DataRow dr in table.Rows)
            {
                dr.Delete();
            }
            table.AcceptChanges();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
            string[] dataValues;
            rows = 0;
            while (!sr.EndOfStream)
            {
                string rowData = sr.ReadLine().Trim();
                if (rowData.Length > 0)
                {
                    table.Rows.Add();
                    dataValues = rowData.Split(',');
                    for (int i = 0; i < 4; i++)
                    {
                        dataGridView1[i, rows].Value = dataValues[i];
                    }
                }
                rows++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            readFile();
        }
        
        private void Simulate_Click(object sender, EventArgs e)
        {
            if (FIFO.Checked)
            {
                FCFS();
                textBox1.Text = averageFCFS.ToString();
            }
            else if (SJB.Checked)
            {
                if (Preemptive.Checked)
                {
                    SJB_Preemptive();
                    textBox1.Text = averageSJFP.ToString();
                }
                else
                {
                    SJB_NonPreemptive();
                    textBox1.Text = averageSJF.ToString();
                }
            }
            else if (Priority.Checked)
            {
                Priority_NonPreemptive();
                textBox1.Text = averagePRIO.ToString();
            }
            else if (Round_Robin.Checked)
            {
                RoundRobin();
                textBox1.Text = averageRR.ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            quantum = Convert.ToInt32(numericUpDown1.Value);
        }

        private void Preemptive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t = 0;
            int i = 0;
            int complete = 0;
            int processNumber=0;
            fillTheList();
            Sort_According_to_Arrival_time();
            int highestPriority = readyProcess[0].Priority; ;
            List<int> burstTime = new List<int>();
            for (int k = 0; k < rows; k++)
            {
                burstTime.Add(readyProcess[k].BurstTime);
            }
            while (complete != rows)
            {
                int temp = 0;
                bool flag = false;
                bool flag1=false;
               // MessageBox.Show(readyProcess[i].ProcessID.ToString());
                //MessageBox.Show(i.ToString());
                if (burstTime[i] > 0)
                {
                    if (burstTime[i] < readyProcess[i + 1].ArrivedTime )
                    {
                        t += burstTime[i];
                        burstTime[i] = 0;
                        flag = true;
                    }
                    else if (flag == false)
                    {
                        if (readyProcess[i].Priority < readyProcess[i + 1].Priority)
                        {
                            t += burstTime[i];
                            burstTime[i] -= t;
                            if (burstTime[i] > 0)
                            {
                                temp = t;
                            }
                            flag1 = true;
                        }
                        else if (flag1 == false)
                        {
                            t += readyProcess[i + 1].ArrivedTime;
                            burstTime[i] -= t;
                            if (burstTime[i] > 0)
                            {
                                temp = t;
                            }
                        }
                    }
                    else
                    {
                        if (i == rows - 1)
                        {
                            t += burstTime[i];
                        }
                    }
                }
                if (i == 0)
                    readyProcess[0].WaitingTime = 0;
                else
                    readyProcess[i].WaitingTime = t - readyProcess[i].ArrivedTime;
                //MessageBox.Show(readyProcess[i].WaitingTime.ToString());
                MessageBox.Show(t.ToString());

                if (burstTime[i] <= 0)
                {
                    readyProcess[i].Priority = 1000;
                    highestPriority = 1000;
                }
                //MessageBox.Show(burstTime[i].ToString());
                for (int j = 0; j < rows; j++)
                {
                    if (readyProcess[j].Priority < highestPriority && burstTime[j] > 0 && t >= readyProcess[j].ArrivedTime)
                    {
                        highestPriority = readyProcess[j].Priority;
                        for (int l=0 ; l<rows ;l++)
                        {
                            if (highestPriority > readyProcess[l].Priority)
                            {
                                highestPriority = readyProcess[l].Priority;
                            }
                        }
                    }
                }
                for (int count = 0; count < rows; count++)
                {
                    if (readyProcess[count].Priority == highestPriority)
                        processNumber = readyProcess[count].ProcessID;
                }

                //i = processNumber-1;
                 // MessageBox.Show(processNumber.ToString());
                    if (burstTime[i] <= 0)
                    {
                        complete++;
                        i = processNumber-1;
                        //MessageBox.Show(readyProcess[i].ProcessID.ToString());
                    }
                    else
                    {
                        i = processNumber-1;
                        //MessageBox.Show(readyProcess[i].ProcessID.ToString());
                    }

            }
        }

        public int l { get; set; }
    }
}
