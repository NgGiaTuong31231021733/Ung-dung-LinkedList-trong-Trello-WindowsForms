using System.Drawing;
using System.Windows.Forms;

namespace Winform_doancuoiky_CTDL_GT
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.toDoList = new System.Windows.Forms.ListView();
            this.addTaskToDoButton = new System.Windows.Forms.Button();
            this.inProgressList = new System.Windows.Forms.ListView();
            this.addTaskInProgressButton = new System.Windows.Forms.Button();
            this.doneList = new System.Windows.Forms.ListView();
            this.addTaskDoneButton = new System.Windows.Forms.Button();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.addListButton = new System.Windows.Forms.Button();
            this.labelToDo = new System.Windows.Forms.Label();
            this.labelInProgress = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toDoList
            // 
            this.toDoList.HideSelection = false;
            this.toDoList.Location = new System.Drawing.Point(16, 15);
            this.toDoList.Margin = new System.Windows.Forms.Padding(4);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(265, 245);
            this.toDoList.TabIndex = 0;
            this.toDoList.UseCompatibleStateImageBehavior = false;
            // 
            // addTaskToDoButton
            // 
            this.addTaskToDoButton.Location = new System.Drawing.Point(16, 268);
            this.addTaskToDoButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTaskToDoButton.Name = "addTaskToDoButton";
            this.addTaskToDoButton.Size = new System.Drawing.Size(265, 28);
            this.addTaskToDoButton.TabIndex = 1;
            this.addTaskToDoButton.Tag = this.toDoList;
            this.addTaskToDoButton.Text = "Add Card";
            this.addTaskToDoButton.UseVisualStyleBackColor = true;
            this.addTaskToDoButton.Click += new System.EventHandler(this.addTaskToDoButton_Click);
            // 
            // inProgressList
            // 
            this.inProgressList.HideSelection = false;
            this.inProgressList.Location = new System.Drawing.Point(291, 15);
            this.inProgressList.Margin = new System.Windows.Forms.Padding(4);
            this.inProgressList.Name = "inProgressList";
            this.inProgressList.Size = new System.Drawing.Size(265, 245);
            this.inProgressList.TabIndex = 2;
            this.inProgressList.UseCompatibleStateImageBehavior = false;
            // 
            // addTaskInProgressButton
            // 
            this.addTaskInProgressButton.Location = new System.Drawing.Point(291, 268);
            this.addTaskInProgressButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTaskInProgressButton.Name = "addTaskInProgressButton";
            this.addTaskInProgressButton.Size = new System.Drawing.Size(265, 28);
            this.addTaskInProgressButton.TabIndex = 3;
            this.addTaskInProgressButton.Tag = this.inProgressList;
            this.addTaskInProgressButton.Text = "Add Card";
            this.addTaskInProgressButton.UseVisualStyleBackColor = true;
            this.addTaskInProgressButton.Click += new System.EventHandler(this.addTaskInProgressButton_Click);
            // 
            // doneList
            // 
            this.doneList.HideSelection = false;
            this.doneList.Location = new System.Drawing.Point(565, 15);
            this.doneList.Margin = new System.Windows.Forms.Padding(4);
            this.doneList.Name = "doneList";
            this.doneList.Size = new System.Drawing.Size(265, 245);
            this.doneList.TabIndex = 4;
            this.doneList.UseCompatibleStateImageBehavior = false;
            // 
            // addTaskDoneButton
            // 
            this.addTaskDoneButton.Location = new System.Drawing.Point(565, 268);
            this.addTaskDoneButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTaskDoneButton.Name = "addTaskDoneButton";
            this.addTaskDoneButton.Size = new System.Drawing.Size(265, 28);
            this.addTaskDoneButton.TabIndex = 5;
            this.addTaskDoneButton.Tag = this.doneList;
            this.addTaskDoneButton.Text = "Add Card";
            this.addTaskDoneButton.UseVisualStyleBackColor = true;
            this.addTaskDoneButton.Click += new System.EventHandler(this.addTaskDoneButton_Click);
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.Location = new System.Drawing.Point(16, 336);
            this.removeTaskButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(133, 28);
            this.removeTaskButton.TabIndex = 7;
            this.removeTaskButton.Text = "Remove Card";
            this.removeTaskButton.UseVisualStyleBackColor = true;
            this.removeTaskButton.Click += new System.EventHandler(this.removeTaskButton_Click);
            // 
            // addListButton
            // 
            this.addListButton.Location = new System.Drawing.Point(226, 336);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(133, 28);
            this.addListButton.TabIndex = 0;
            this.addListButton.Text = "Add List";
            this.addListButton.UseVisualStyleBackColor = true;
            this.addListButton.Click += new System.EventHandler(this.addListButton_Click);
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.Location = new System.Drawing.Point(16, 0);
            this.labelToDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(45, 16);
            this.labelToDo.TabIndex = 0;
            this.labelToDo.Text = "To Do";
            // 
            // labelInProgress
            // 
            this.labelInProgress.AutoSize = true;
            this.labelInProgress.Location = new System.Drawing.Point(290, 0);
            this.labelInProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInProgress.Name = "labelInProgress";
            this.labelInProgress.Size = new System.Drawing.Size(75, 16);
            this.labelInProgress.TabIndex = 1;
            this.labelInProgress.Text = "In Progress";
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Location = new System.Drawing.Point(566, 0);
            this.labelDone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(40, 16);
            this.labelDone.TabIndex = 2;
            this.labelDone.Text = "Done";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 412);
            this.Controls.Add(this.labelToDo);
            this.Controls.Add(this.labelInProgress);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.addListButton);
            this.Controls.Add(this.removeTaskButton);
            this.Controls.Add(this.addTaskDoneButton);
            this.Controls.Add(this.doneList);
            this.Controls.Add(this.addTaskInProgressButton);
            this.Controls.Add(this.inProgressList);
            this.Controls.Add(this.addTaskToDoButton);
            this.Controls.Add(this.toDoList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Trello Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListView toDoList;
        private System.Windows.Forms.Button addTaskToDoButton;
        private System.Windows.Forms.ListView inProgressList;
        private System.Windows.Forms.Button addTaskInProgressButton;
        private System.Windows.Forms.ListView doneList;
        private System.Windows.Forms.Button addTaskDoneButton;
        private System.Windows.Forms.Button removeTaskButton;
        private System.Windows.Forms.Button addListButton;
        private Label labelToDo;
        private Label labelInProgress;
        private Label labelDone;
    }
}