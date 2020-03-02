using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    
    public partial class Form1 : Form
    {


        public FlightInAtmo Flight = new FlightInAtmo();
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 500;
        }
        
        int i = 0;
        decimal t = 0;

        private void Resume_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        
        
        private void Launch_Click(object sender, EventArgs e)
        {

            if (!timer1.Enabled)

            {

                chart1.Series[0].Points.Clear();

                Flight.set_values(inputHeight.Value, inputAngle.Value, inputSpeed.Value, inputSize.Value, inputWeight.Value);
                
                chart1.Series[0].Points.AddXY(Flight.x, Flight.y);

                timer1.Start();

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                t = Flight.get_time();
                time.Text = t.ToString();

                Flight.step();

                chart1.Series[0].Points.AddXY(Flight.x, Flight.y);

                if (Flight.y < 0) timer1.Stop();
            
        }

    }
    public class FlightInAtmo
    {
        
        public const decimal g = 9.81M, dt = 0.1M, C = 0.15M, rho = 1.29M;
        
        public decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy;
        public double angle;
        

        public void set_values(decimal Height, decimal Angle, decimal Speed, decimal Size, decimal Weight)
        {
            t = 0;
            x = 0;
            y = Height;
            angle = (double)Angle * Math.PI / 180; 
            v0 = Speed;
            S = Size;
            m = Weight;
            cosa = (decimal)Math.Cos(angle);
            sina = (decimal)Math.Sin(angle);
            k = 0.5M * C * rho * S / m;
            vx = v0 * cosa;
            vy = v0 * sina;
        }
        public decimal get_time()
        {
            t += dt;
            return t;
        }
        public void step()
        {
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;

            x = x + vx * dt;

            y = y + vy * dt;
        }
    }
}
