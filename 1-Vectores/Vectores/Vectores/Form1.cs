using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] Players = new String[10];
        Int32 MAXIMUN_PLAYERS = 10;
        Int32 index = 0;

        private void handlerPlayer_Click(object sender, EventArgs e)
        {
            if (index < MAXIMUN_PLAYERS)
            {
                Players[index] = name.Text;
                index++;
                name.Clear();
                return;
            }

            MessageBox.Show("Ya se alcanzo cantida maxima de jugadores");
        }

        private void ListWithFor_Click(object sender, EventArgs e)
        {
            ProcedureListWithFor();
        }

        private void ListWithWhile_Click(object sender, EventArgs e)
        {
            ProcedureListWithWhile();
        }

        private void ProcedureListWithFor()
        {
            listPlayers.Items.Clear();

            foreach (String player in Players)
            {
                listPlayers.Items.Add(player);
            }
        }

        private void ProcedureListWithWhile()
        {
            listPlayers.Items.Clear();
            Int32 index = 0;
            Int32 totalPlayers = Players.Length;

            while (index< totalPlayers)
            {
                listPlayers.Items.Add(Players[index]);
                index++;
            }
        }

        
    }
}
