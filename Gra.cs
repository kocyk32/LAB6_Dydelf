﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
namespace Lab6_Dydelf
{
    public partial class Gra : Form
    {
        private Form1 form;
        private TableLayoutPanel plansza;
        private HashSet<Button> przyciski = new HashSet<Button>();
        private Dictionary<Button, string> fieldContent = new Dictionary<Button, string>();
        private int znalezionedydlefy = 0;
        private Label lblTimer;
        private int pozostalyczas;
        private System.Windows.Forms.Timer gameTimer;
        private int krokodylczas;
        private System.Windows.Forms.Timer krokodylTimer;
        private System.Windows.Forms.Timer SzopTimer;
        public Gra(Form1 form)
        {
            this.form = form;
            InitializeComponent();
            Start();
        }

        private void Gra_Load(object sender, EventArgs e)
        {

        }
        private void Start()
        {
            this.SuspendLayout(); // <<< TU WSTRZYMUJESZ

            this.Size = new Size(600, 600);
            Panel mainPanel = new Panel { Dock = DockStyle.Fill };
            this.Controls.Add(mainPanel);

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            mainPanel.Controls.Add(layout);

            lblTimer = new Label
            {
                Text = $"Pozostały czas: {form.mainczas}s",
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.LightYellow
            };
            layout.Controls.Add(lblTimer, 0, 0);

            plansza = new TableLayoutPanel();
            plansza.RowCount = form.mainX;
            plansza.ColumnCount = form.mainY;
            plansza.Dock = DockStyle.Fill;

            for (int i = 0; i < form.mainX; i++)
                plansza.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / form.mainX));
            for (int j = 0; j < form.mainY; j++)
                plansza.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / form.mainY));

            layout.Controls.Add(plansza, 0, 1);

            List<string> contents = new List<string>();
            contents.AddRange(Enumerable.Repeat("Dydelf", form.maindydlefy));
            contents.AddRange(Enumerable.Repeat("Krokodyl", form.mainkrokodyle));
            contents.AddRange(Enumerable.Repeat("Szop", form.mainszopy));
            int total = form.mainX * form.mainY;
            contents.AddRange(Enumerable.Repeat("Puste", total - contents.Count));
            Random rng = new Random();
            contents = contents.OrderBy(x => rng.Next()).ToList();

            int index = 0;
            for (int i = 0; i < form.mainX; i++)
            {
                for (int j = 0; j < form.mainY; j++)
                {
                    Button btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        BackColor = Color.LightGray,
                        Font = new Font("Arial", 14)
                    };
                    btn.Click += Field_Click;
                    plansza.Controls.Add(btn, j, i);
                    fieldContent[btn] = contents[index++];
                }
            }

            plansza.Refresh(); 

            pozostalyczas = form.mainczas;
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            this.ResumeLayout(); 
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            pozostalyczas--;
            lblTimer.Text = $"Pozostały czas: {pozostalyczas}s";

            if (pozostalyczas <= 0)
            {
                gameTimer.Stop();
                EndGame(false, "Czas minął! Przegrałeś D: ");
            }

        }
        private void KrokodylTimer_Tick(object sender, EventArgs e)
        {
            krokodylczas--;

            if (krokodylczas <= 0)
            {
                krokodylTimer.Stop();
                EndGame(false, "KROKODYL!!! AAAAAAAA!!! Przegrałeś D: ");
            }

        }

        private void Field_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            przyciski.Add(btn);
            string content = fieldContent[btn];

            if (content == "Dydelf")
            {
                btn.BackColor = Color.Green;
                btn.Text = "🐭";
                znalezionedydlefy++;

                if (znalezionedydlefy == form.maindydlefy)
                    EndGame(true, "Wszystkie Dydelfy znalezione!!! Brawo!!!");
            }
            else if (content == "Krokodyl")
            {

                if (btn.Text == "🐊")
                {
                    btn.BackColor = Color.LightGray;
                    btn.Text = "";
                    krokodylTimer.Stop();

                }
                else
                {
                    krokodylczas = 2;
                    krokodylTimer = new System.Windows.Forms.Timer();
                    krokodylTimer.Interval = 1000;
                    krokodylTimer.Tick += KrokodylTimer_Tick;
                    krokodylTimer.Start();
                    btn.BackColor = Color.Red;
                    btn.Text = "🐊";

                }







            }
            else if (content == "Szop")
            {

                btn.BackColor = Color.Blue;
                btn.Text = "🦝";
                SzopTimer = new System.Windows.Forms.Timer();
                SzopTimer.Interval = 2000;
                SzopTimer.Start();
                SzopTimer.Tick += (s, args) =>
                {
                    SzopTimer.Stop();
                    btn.Text = "";
                    btn.BackColor = Color.LightGray;
                    var neighbors = Sasiedzi(btn);
                    foreach (var neighbor in neighbors)
                    {
                        if (neighbor.Text == "🐭")
                        {
                            znalezionedydlefy--;
                        }
                        if (neighbor.Text == "🐊")
                        {
                            krokodylTimer.Stop();
                        }



                        neighbor.Text = "";
                        neighbor.BackColor = Color.LightGray;

                    }







                };
            }
            else
            {
                btn.BackColor = Color.White;
            }
        }
        private List<Button> Sasiedzi(Button btn)
        {
            List<Button> neighbors = new List<Button>();
            int rzad = plansza.GetRow(btn);
            int kolumna = plansza.GetColumn(btn);

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    int nrzad = rzad + i;
                    int nkolumna = kolumna + j;


                    if (nrzad >= 0 && nrzad < form.mainX && nkolumna >= 0 && nkolumna < form.mainY)
                    {
                        Button neighbor = plansza.GetControlFromPosition(nkolumna, nrzad) as Button;
                        if (neighbor != null)
                        {
                            neighbors.Add(neighbor);
                        }
                    }
                }
            }

            return neighbors;
        }

        private void EndGame(bool success, string message)
        {


            MessageBox.Show(message, success ? "Wygrana!" : "Przegrana");
            this.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
