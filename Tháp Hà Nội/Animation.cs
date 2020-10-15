using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tháp_Hà_Nội
{
    public class Animation
    {
        public static Panel View;
        public void MoveUp(PictureBox Disk, int newY)
        {
            while (Disk.Location.Y > newY)
            {
                Disk.Location = new System.Drawing.Point(Disk.Location.X, Disk.Location.Y - 10);
                View.Refresh();
                Thread.Sleep(10);
            }
        }
        public void MoveDown(PictureBox Disk, int newY)
        {
            while (Disk.Location.Y < newY)
            {
                Disk.Location = new System.Drawing.Point(Disk.Location.X, Disk.Location.Y + 10);
                View.Refresh();
                Thread.Sleep(10);
            }
        }
        public void MoveLeft(PictureBox Disk, int newX)
        {
            while (Disk.Location.X > newX)
            {
                Disk.Location = new System.Drawing.Point(Disk.Location.X - 10, Disk.Location.Y);
                View.Refresh();
                Thread.Sleep(10);
            }
        }
        public void MoveRight(PictureBox Disk, int newX)
        {
            while (Disk.Location.X < newX)
            {
                Disk.Location = new System.Drawing.Point(Disk.Location.X + 10, Disk.Location.Y);
                View.Refresh();
                Thread.Sleep(10);
            }
        }
    }
}
