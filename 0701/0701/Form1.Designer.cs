﻿using System;
using System.Threading;

namespace _0701
{
    partial class Form1
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblGratulacio = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mskdTxtSzuldatum = new System.Windows.Forms.MaskedTextBox();
            this.txtEvSzam = new System.Windows.Forms.TextBox();
            this.txtNap = new System.Windows.Forms.TextBox();
            this.txtNapSorszam = new System.Windows.Forms.TextBox();
            this.txtKesobbiDatum = new System.Windows.Forms.TextBox();
            this.txtNapSzam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKiir = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(156, 52);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(35, 13);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "label1";
            // 
            // lblGratulacio
            // 
            this.lblGratulacio.AutoSize = true;
            this.lblGratulacio.Location = new System.Drawing.Point(250, 228);
            this.lblGratulacio.Name = "lblGratulacio";
            this.lblGratulacio.Size = new System.Drawing.Size(35, 13);
            this.lblGratulacio.TabIndex = 1;
            this.lblGratulacio.Text = "label2";
            this.lblGratulacio.Click += new System.EventHandler(this.lblGratulacio_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mskdTxtSzuldatum
            // 
            this.mskdTxtSzuldatum.Location = new System.Drawing.Point(121, 117);
            this.mskdTxtSzuldatum.Name = "mskdTxtSzuldatum";
            this.mskdTxtSzuldatum.Size = new System.Drawing.Size(100, 20);
            this.mskdTxtSzuldatum.TabIndex = 0;
            this.mskdTxtSzuldatum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskdTxtSzuldatum_KeyPress);
            this.mskdTxtSzuldatum.Leave += new System.EventHandler(this.mskdTxtSzuldatum_Leave_1);
            // 
            // txtEvSzam
            // 
            this.txtEvSzam.Location = new System.Drawing.Point(121, 167);
            this.txtEvSzam.Name = "txtEvSzam";
            this.txtEvSzam.Size = new System.Drawing.Size(100, 20);
            this.txtEvSzam.TabIndex = 4;
            // 
            // txtNap
            // 
            this.txtNap.Location = new System.Drawing.Point(386, 167);
            this.txtNap.Name = "txtNap";
            this.txtNap.Size = new System.Drawing.Size(100, 20);
            this.txtNap.TabIndex = 5;
            // 
            // txtNapSorszam
            // 
            this.txtNapSorszam.Location = new System.Drawing.Point(424, 297);
            this.txtNapSorszam.Name = "txtNapSorszam";
            this.txtNapSorszam.Size = new System.Drawing.Size(100, 20);
            this.txtNapSorszam.TabIndex = 6;
            // 
            // txtKesobbiDatum
            // 
            this.txtKesobbiDatum.Location = new System.Drawing.Point(424, 332);
            this.txtKesobbiDatum.Name = "txtKesobbiDatum";
            this.txtKesobbiDatum.Size = new System.Drawing.Size(100, 20);
            this.txtKesobbiDatum.TabIndex = 7;
            // 
            // txtNapSzam
            // 
            this.txtNapSzam.Location = new System.Drawing.Point(201, 332);
            this.txtNapSzam.Name = "txtNapSzam";
            this.txtNapSzam.Size = new System.Drawing.Size(100, 20);
            this.txtNapSzam.TabIndex = 8;
            this.txtNapSzam.TextChanged += new System.EventHandler(this.txtNapSzam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pontos dátum és idő";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Születési dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ennyi éves vagy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ilyen napon születtél";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "nappal későbbi dátum";
            // 
            // btnKiir
            // 
            this.btnKiir.Location = new System.Drawing.Point(47, 404);
            this.btnKiir.Name = "btnKiir";
            this.btnKiir.Size = new System.Drawing.Size(75, 23);
            this.btnKiir.TabIndex = 14;
            this.btnKiir.Text = "Kiír";
            this.btnKiir.UseVisualStyleBackColor = true;
            this.btnKiir.Click += new System.EventHandler(this.btnKiir_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(226, 404);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 15;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(424, 404);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 16;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tetszőleges dátum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ez az év ennyiedik napja:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnKiir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNapSzam);
            this.Controls.Add(this.txtKesobbiDatum);
            this.Controls.Add(this.txtNapSorszam);
            this.Controls.Add(this.txtNap);
            this.Controls.Add(this.txtEvSzam);
            this.Controls.Add(this.mskdTxtSzuldatum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblGratulacio);
            this.Controls.Add(this.lblDatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void mskdSzulDatum_Leave(object v, object sender, EventArgs eventArgs, object e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblGratulacio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox mskdTxtSzuldatum;
        private System.Windows.Forms.TextBox txtEvSzam;
        private System.Windows.Forms.TextBox txtNap;
        private System.Windows.Forms.TextBox txtNapSorszam;
        private System.Windows.Forms.TextBox txtKesobbiDatum;
        private System.Windows.Forms.TextBox txtNapSzam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKiir;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Label label6;
        private object e;
        private System.Windows.Forms.Label label7;
    }
}

