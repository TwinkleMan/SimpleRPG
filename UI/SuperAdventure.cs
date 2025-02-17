﻿using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SuperAdventure : Form
    {

        private Player _player;

        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player();

            _player.MaximumHitPoints = 10;
            _player.CurrentHitPoints = 10;
            _player.ExperiencePoints = 0;
            _player.Level = 1;
            _player.Gold = 20;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}
