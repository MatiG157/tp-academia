﻿namespace WindowsForms
{
    partial class ClientesLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clientesDataGridView = new DataGridView();
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientesDataGridView
            // 
            clientesDataGridView.AllowUserToOrderColumns = true;
            clientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesDataGridView.Location = new Point(24, 24);
            clientesDataGridView.Margin = new Padding(2, 2, 2, 2);
            clientesDataGridView.MultiSelect = false;
            clientesDataGridView.Name = "clientesDataGridView";
            clientesDataGridView.ReadOnly = true;
            clientesDataGridView.RowHeadersWidth = 82;
            clientesDataGridView.RowTemplate.Height = 41;
            clientesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientesDataGridView.Size = new Size(858, 360);
            clientesDataGridView.TabIndex = 0;
            clientesDataGridView.CellContentClick += clientesDataGridView_CellContentClick;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(790, 401);
            agregarButton.Margin = new Padding(2, 2, 2, 2);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(92, 29);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(578, 401);
            eliminarButton.Margin = new Padding(2, 2, 2, 2);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(92, 29);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(684, 401);
            modificarButton.Margin = new Padding(2, 2, 2, 2);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(92, 29);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // ClientesLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 536);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(clientesDataGridView);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ClientesLista";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientesDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
    }
}