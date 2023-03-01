using CISESPORT2.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT2
{
    public partial class Findlayer : Form
    {
        PlayerClass Player;
        public Findlayer()
        {
            InitializeComponent();
            foreach(PlayerClass player_ in Players.instant.listplayer) 
            {
                dataGridView1.Rows.Add(player_.Name, player_.lastname, player_.iD, player_.major, player_.Display, player_.mail, player_.Number, player_.Age);
            }
        }
        public PlayerClass getPlayer()
        {
            return Player;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            PlayerClass pp = Players.instant.listplayer[dataGridView1.CurrentRow.Index];
            Player = pp;
            this.DialogResult= DialogResult.OK;
        }
    }
}
