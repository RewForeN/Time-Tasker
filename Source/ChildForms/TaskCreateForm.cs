﻿
using System;
using System.Windows.Forms;


namespace TimeTasker {

	public partial class TaskCreateForm : Form {


		private TasksForm myForm;

		public TaskCreateForm(TasksForm form) {

			InitializeComponent();

			myForm = form;

			BackgroundImage = form.DarkenedBitmapFromForm();

			pnl1.BackColor = Settings.ColorTheme;
			pnl2.BackColor = Settings.ColorTheme;
			pnl3.BackColor = Settings.ColorTheme;
			pnl4.BackColor = Settings.ColorTheme;
			drpPriority.SelectedIndex = 0;

			Show();

		}

		private void btnCreate_Click(object sender, EventArgs e) {

			Task task = new Task(txtMessage.Text, false, DateTime.Now, dtpDueDate.Value, drpPriority.SelectedIndex);
			myForm.AddTask(task);

			Close();

		}

		private void TaskCreateForm_Click(object sender, EventArgs e) {

			Close();

		}

	}

}
