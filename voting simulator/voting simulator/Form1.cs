using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Specialized;

namespace voting_simulator
{
    public partial class Form1 : Form
    {
        string filetext;
        string[] fileline;
        private bool isCollapsed = true;
        int method = 1;
        char delimiter = ' ';
        public Form1()
        {
            InitializeComponent();
        }
        private void fileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Open Text File";
            file.Filter = "TXT files|*.txt";
            file.InitialDirectory = @"C:\";
            if (file.ShowDialog() == DialogResult.OK)
            {
                location.Text = file.FileName;
                filetext = File.ReadAllText(file.FileName);
                fileline = File.ReadAllLines(file.FileName);
                data.Text = filetext;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simulate_Click(object sender, EventArgs e)
        {
            try
            {
                ResultLabel.Text = "";
                matrixLabel.Text = "";
                if (data.Text != "")
                {
                    ListDictionary candidates = new ListDictionary();
                    int numvoters = fileline.Length;
                    if (method == 1)
                    {
                        numvoters = firstChoice(candidates);
                    }
                    else if (method == 2)
                    {
                        numvoters = preferenceChoice(candidates);
                    }
                    else if (method == 3)
                    {
                        numvoters = pairwiseChoice(candidates);
                    }
                    updateText(candidates, numvoters);
                }
                else
                {
                    ResultLabel.Text = "There is no data to simulate";
                }
            }
            catch
            {
                ResultLabel.Text = "An error has occurred";
            }
        }
    

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                dropdownmenu.Height += 10;
                if (dropdownmenu.Size == dropdownmenu.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                dropdownmenu.Height -= 10;
                if (dropdownmenu.Size == dropdownmenu.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void dropdown_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void data_TextChanged(object sender, EventArgs e)
        {
            filetext = data.Text;
            fileline = data.Lines;
        }

        private void method2_Click(object sender, EventArgs e)
        {
            method = 1;
        }

        private void method3_Click(object sender, EventArgs e)
        {
            method = 2;
        }

        private void pairwise_Click(object sender, EventArgs e)
        {
            method = 3;
        }

        private void delimiterText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                delimiter = delimiterText.Text[0];
                error.Text = "delimiter changed.";
            }
            catch
            {
                delimiter = ' ';
                error.Text = "delimiter has been defaulted back to a space.";
            }
        }

        public int firstChoice(ListDictionary candidates)
        {
            //for calculating the percentage of votes later
            int numvoters = 0;

            //if a candidate is placed first in a row it gets a point
            foreach (string line in fileline)
            {
                string[] votes = line.Split(delimiter);
                foreach (string vote in votes)
                {
                    if (votes[0]!=vote || !amountCheck.Checked)
                    {
                        if (!candidates.Contains(vote))
                        {
                            candidates.Add(vote, 0);
                        }
                    }
                }
                if (amountCheck.Checked)
                {
                    numvoters = numvoters + Convert.ToInt32(votes[0]);
                    candidates[votes[1]] = Convert.ToInt32(candidates[votes[1]]) + Convert.ToInt32(votes[0]);
                }
                else
                {
                    numvoters = fileline.Length;
                    candidates[votes[0]] = Convert.ToInt32(candidates[votes[0]]) + 1;
                }
            }
            return numvoters;
        }

        public int preferenceChoice(ListDictionary candidates)
        {
            //for calculating the percentage of votes later
            int numvoters = 0;
            //gives more points the higher up a candidate is placed
            foreach (string line in fileline)
            {
                string[] votes = line.Split(delimiter);
                int ii = votes.Length - 1;
                if (amountCheck.Checked)
                {
                    ii--;
                }
                for (int i = 0; i < votes.Length; i++)
                {
                    int iii = ii;
                    if (amountCheck.Checked)
                    {
                        if (i == 0)
                        {
                            i++;
                        }
                        iii = ii * Convert.ToInt32(votes[0]);
                    }
                    candidates[votes[i]] = Convert.ToInt32(candidates[votes[i]]) + iii;
                    numvoters = numvoters + iii;
                    ii--;
                }
            }
            return numvoters;
        }


        public int pairwiseChoice(ListDictionary candidates)
        {
            ListDictionary matrix = new ListDictionary();

            int numvoters = 0; //for calculating the percentage of votes later

            //finds all of the possible candidates
            string[] votes = fileline[0].Split(delimiter);
            foreach (string vote in votes)
            {
                if (votes[0] != vote || !amountCheck.Checked)
                {
                    candidates.Add(vote, 0);
                }
            }

            //finds all of the possible matchups
            foreach (string candidate in candidates.Keys)
            {
                foreach (string candidate2 in candidates.Keys)
                {
                    if(candidate != candidate2)
                    {
                        matrix.Add(candidate + "," + candidate2, 0);
                    }
                }
            }

            //For loop through each pair to find who wins against all possible matchups
            foreach (string line in fileline)
            {
                votes = line.Split(delimiter);
                for (int i = 0; i < votes.Length; i++)
                {
                    for (int ii = 0; ii < votes.Length; ii++)
                    {
                        if (i < ii)
                        {
                            if(amountCheck.Checked)
                            {
                                matrix[votes[i] + ',' + votes[ii]] = Convert.ToInt32(matrix[votes[i] + ',' + votes[ii]]) + Convert.ToInt32(votes[0]);
                            }
                            else
                            {
                                matrix[votes[i] + ',' + votes[ii]] = Convert.ToInt32(matrix[votes[i] + ',' + votes[ii]]) + 1;
                            }
                        }
                    }
                }
            }

            //for printing out the matrix
            foreach (string candidate in candidates.Keys)
            {
                foreach (string candidate2 in candidates.Keys)
                {
                    if (candidate != candidate2)
                    {
                        matrixLabel.Text = matrixLabel.Text + candidate + ',' + candidate2;
                        matrixLabel.Text = matrixLabel.Text + ":" + matrix[candidate + ',' + candidate2] + ' ' + ' ';
                    }
                }
                matrixLabel.Text = matrixLabel.Text + "\n";
            }

            //the number of times a candidate wins against another candidate on the matrix
            votes = fileline[0].Split(delimiter);
            foreach (string vote in votes)
            {
                foreach (string vote2 in votes)
                {
                    if (votes[0] != vote || !amountCheck.Checked)
                    {
                        if(Convert.ToInt32(matrix[vote + ',' + vote2])> Convert.ToInt32(matrix[vote2 + ',' + vote]))
                        {
                            candidates[vote] = Convert.ToInt32(candidates[vote]) + 1;
                            numvoters++;
                        }
                    }
                }
            }

            return numvoters;
        }

        public int countVotes()
        {
            int numvoters = 0;

            foreach (string line in fileline)
            {
                string[] votes = line.Split(delimiter);
                if (amountCheck.Checked)
                {
                    numvoters = numvoters + Convert.ToInt32(votes[0]);
                }
                else
                {
                    numvoters = fileline.Length;
                }
            }
            return numvoters;
        }

        public void updateText(ListDictionary candidates, int numvoters)
        {
            string winner = "";
            int winnervotes = 0;
            foreach (DictionaryEntry candidate in candidates)
            {
                //you can't divide by zero
                if (numvoters != 0)
                {
                    //percentage of votes
                    int avg = (Convert.ToInt32(candidate.Value) * 100) / numvoters;
                    ResultLabel.Text = ResultLabel.Text + candidate.Key + ": " + candidate.Value + " (" + avg.ToString() + "%)" + "\n";
                }
                else
                {
                    ResultLabel.Text = ResultLabel.Text + candidate.Key + ": " + candidate.Value + " (" + 0 + "%)" + "\n";
                }

                if (winnervotes < Convert.ToInt32(candidate.Value))
                {
                    winner = candidate.Key.ToString();
                    winnervotes = Convert.ToInt32(candidate.Value);
                }
                else if (winnervotes == Convert.ToInt32(candidate.Value))
                {
                    winner = winner + ", " + candidate.Key.ToString();
                }
            }
            numvoters = countVotes(); //just so we don't print the number of points allocated and rather just do the number of voters
            ResultLabel.Text = ResultLabel.Text + "\n\nTotal votes: " + numvoters + "\nWinner:" + winner;
        }
    }
}
