using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tháp_Hà_Nội
{
    public partial class Form1 : Form
    {
        private List<Disk> ListDisk = new List<Disk>();         //List of disks
        Animation MoveAnimation = new Animation();              //Move disk animation
        int DiskCount = 1;                                      //Number of disks
        int DiskHeight = 30;                                    //Height of disk
        int BaseHeight = 30;                                    //Height of base (bottom bar)
        public Form1()
        {
            InitializeComponent();
            Animation.View = pnlStimulation;
            RefreshPanel();
            btnNew.Enabled = false;
        }
        /// <summary>
        /// Create Disk on Panel
        /// </summary>
        private void CreateDisk()
        {
            int Const = 1;
            foreach (Disk disk in ListDisk)
            {
                PictureBox DiskBox = disk.DiskBox;
                DiskBox.BackColor = ColorDisk(disk);
                disk.DiskWidth = 210 - (15 * Const);
                DiskBox.Width = disk.DiskWidth;
                DiskBox.Height = DiskHeight;
                DiskBox.Tag = disk.DiskNumber;
                DiskBox.BorderStyle = BorderStyle.FixedSingle;
                Point DiskBoxLocation = new Point(GetDiskX(disk),
                    (pnlStimulation.Height - BaseHeight) - (DiskHeight * Const++));
                DiskBox.Location = DiskBoxLocation;
                disk.DiskBox = DiskBox;
                pnlStimulation.Controls.Add(disk.DiskBox);
            }
        }
        /// <summary>
        /// Get X position for Disk 
        /// </summary>
        /// <param name="disk">Disk to check</param>
        /// <returns>X position for Disk</returns>
        private int GetDiskX(Disk disk)
        {
            int X = 0;
            int Peg = 0;
            switch (disk.Peg)
            {
                case 'A': Peg = 1; break;
                case 'B': Peg = 2; break;
                case 'C': Peg = 3; break;
            }
            X = ((pnlStimulation.Width / 4) * Peg) - (int)(disk.DiskWidth / 2);

            return X;
        }
        /// <summary>
        /// Get Y position for Disk
        /// </summary>
        /// <param name="disk">Disk to check</param>
        /// <returns>Y position for Disk</returns>
        private int GetDiskY(Disk disk)
        {
            int Y = 0;
            int stackNo = ListDisk.Count(x => x.Peg == disk.Peg);
            Y = pnlStimulation.Height - BaseHeight - (DiskHeight * stackNo);
            return Y;
        }
        /// <summary>
        /// Refresh the Panel
        /// </summary>
        private void RefreshPanel()
        {
            //Create pegs for Tower
            DrawOnPanel();
            pnlStimulation.Controls.Clear();
            ListDisk = Enumerable.Range(1, DiskCount).Select(i => new Disk()
            {
                DiskNumber = i,
                Peg = 'A',
                DiskBox = new PictureBox()
            }).OrderByDescending(i => i.DiskNumber).ToList();
            //Place Disk on panel
            CreateDisk();
            //Set initial text value for least possible ListMove
            lblNumberOfMoves.Text = CountOfMoves(DiskCount).ToString();
        }
        /// <summary>
        /// Select color of disk
        /// </summary>
        /// <param name="disk">Disk to select color</param>
        /// <returns></returns>
        private Color ColorDisk(Disk disk)
        {
            switch (disk.DiskNumber)
            {
                case 1: return Color.Red;
                case 2: return Color.OrangeRed;
                case 3: return Color.Yellow;
                case 4: return Color.Green;
                case 5: return Color.Blue;
                case 6: return Color.Purple;
                case 7: return Color.LightBlue;
                case 8: return Color.Aqua;
                case 9: return Color.Cornsilk;
                default: return Color.SteelBlue;
            }
        }
        /// <summary>
        /// Setup tower values, process tower and display moves required
        /// </summary>
        /// <param name="NumberOfDisk">Number of Disk within the tower scenario</param>
        private void Solve(int NumberOfDisk)
        {
            char StartPeg = 'A';                                // start tower in output
            char TempPeg = 'B';                                 // temporary tower in output
            char FinishPeg = 'C';                               // end tower in output
            //Solve towers using recursive method
            TowerOfHanoi(NumberOfDisk, StartPeg, FinishPeg, TempPeg);
        }
        /// <summary>
        /// Recursive Method to solve Tower of Hanoi
        /// </summary>
        /// <param name="DiskMove">Disk to move</param>
        /// <param name="StartPeg">Peg to take disk from</param>
        /// <param name="FinishPeg">Peg to move disk to</param>
        /// <param name="TempPeg">Auxiliary peg</param>
        private void TowerOfHanoi(int DiskMove, char StartPeg, char FinishPeg, char TempPeg)
        {
            if (DiskMove > 0)
            {
                TowerOfHanoi(DiskMove - 1, StartPeg, TempPeg, FinishPeg);

                Disk CurrentDisk = ListDisk.Find(x => x.DiskNumber == DiskMove);
                CurrentDisk.Peg = FinishPeg;

                //Animation
                MoveAnimation.MoveUp(CurrentDisk.DiskBox, 50);
                if (StartPeg < FinishPeg)  //Move Right
                    MoveAnimation.MoveRight(CurrentDisk.DiskBox, GetDiskX(CurrentDisk));
                else                        //Move Left
                    MoveAnimation.MoveLeft(CurrentDisk.DiskBox, GetDiskX(CurrentDisk));
                MoveAnimation.MoveDown(CurrentDisk.DiskBox, GetDiskY(CurrentDisk));

                TowerOfHanoi(DiskMove - 1, TempPeg, FinishPeg, StartPeg);
            }
        }
        /// <summary>
        /// Get the least amount of moves required to solve the tower
        /// </summary>
        /// <param name="DiskCount">Total number of Disk in tower</param>
        /// <returns>Number of moves</returns>
        public static int CountOfMoves(int DiskCount)
        {
            return (int)Math.Pow(2.0, (double)DiskCount) - 1;
        }
        /// <summary>
        /// Value changed listener to set informational label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudDiskCount_ValueChanged(object sender, EventArgs e)
        {
            DiskCount = (int)nudDiskCount.Value;
            RefreshPanel();
        }
        /// <summary>
        /// Draw tower on Panel
        /// </summary>
        private void DrawOnPanel()
        {
            pnlStimulation.Paint += delegate
            {
                DrawTower();
            };
        }
        /// <summary>
        /// Draw a peg 
        /// </summary>
        /// <param name="panel">Panel to draw pegs on</param>
        /// <param name="grp">Graphics object</param>
        /// <param name="brush">SolidBrush</param>
        /// <param name="PegNumber">Peg Number 1-3</param>
        /// <param name="PegWidth">Desired peg width</param>
        /// <param name="TopSpacing">Spacing from the top</param>
        private void DrawPeg(Panel panel, Graphics grp, SolidBrush brush, int PegNumber, int PegWidth, int TopSpacing)
        {
            grp.FillRectangle(brush, ((int)(panel.Width / 4) * PegNumber) - (PegWidth / 2), TopSpacing, PegWidth, panel.Height - TopSpacing);
        }
        /// <summary>
        /// Draw tower (base and 3 pegs)
        /// </summary>
        private void DrawTower()
        {
            SolidBrush brush = new SolidBrush(Color.SandyBrown);
            Graphics grp = pnlStimulation.CreateGraphics();
            int TopSpacing = 150;
            int PegWidth = 10;
            //Draw base
            grp.FillRectangle(brush, 0,
                pnlStimulation.Height - BaseHeight,
                pnlStimulation.Width, BaseHeight);
            //Draw peg 1
            DrawPeg(pnlStimulation, grp, brush, 1, PegWidth, TopSpacing);
            //Draw peg 2
            DrawPeg(pnlStimulation, grp, brush, 2, PegWidth, TopSpacing);
            //Draw peg 3
            DrawPeg(pnlStimulation, grp, brush, 3, PegWidth, TopSpacing);
        }
        /// <summary>
        /// Button click event to solve tower
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSolve_Click(object sender, EventArgs e)
        {
            RefreshPanel();
            btnSolve.Enabled = false;
            nudDiskCount.Enabled = false;
            Solve(DiskCount);
            btnNew.Enabled = true;
        }
        /// <summary>
        /// Button click event to create new tower after solve completely
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            RefreshPanel();
            btnSolve.Enabled = true;
            btnNew.Enabled = false;
            nudDiskCount.Enabled = true;
        }
    }
}
