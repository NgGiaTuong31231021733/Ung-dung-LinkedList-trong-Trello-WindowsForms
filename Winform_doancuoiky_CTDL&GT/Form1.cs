using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Winform_doancuoiky_CTDL_GT
{
    public partial class Form1 : Form
    {
        private LinkedList<ListView> lists;
        private LinkedList<ListViewItem> selectedItems;

        public Form1()
        {
            InitializeComponent();
            InitializeLists();
            selectedItems = new LinkedList<ListViewItem>();
        }

        private void InitializeLists()
        {
            lists = new LinkedList<ListView>();
            lists.AddLast(toDoList);
            lists.AddLast(inProgressList);
            lists.AddLast(doneList);

            foreach (ListView list in lists)
            {
                list.MultiSelect = false;
                list.View = View.List;
                list.Click += List_Click;
                list.AllowDrop = true;
                list.ItemDrag += List_ItemDrag;
                list.DragEnter += List_DragEnter;
                list.DragDrop += List_DragDrop;
            }
        }


        private void List_Click(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            if (listView.SelectedItems.Count > 0)
            {
                selectedItems.AddLast(listView.SelectedItems[0]);
            }
        }

        private string GetTaskNameFromUserInput(string prompt, string title)
        {
            return Interaction.InputBox(prompt, title);
        }

        private void addTaskToDoButton_Click(object sender, EventArgs e)
        {
            ListView listView = (sender as Button).Tag as ListView;

            string taskName = GetTaskNameFromUserInput("Enter Task Name", "Add Card to ToDo");
            if (!string.IsNullOrEmpty(taskName))
            {
                listView.Items.Add(taskName);
            }
        }

        private void addTaskInProgressButton_Click(object sender, EventArgs e)
        {
            ListView listView = (sender as Button).Tag as ListView;

            string taskName = GetTaskNameFromUserInput("Enter Task Name", "Add Card to InProgress");
            if (!string.IsNullOrEmpty(taskName))
            {
                listView.Items.Add(taskName);
            }
        }

        private void addTaskDoneButton_Click(object sender, EventArgs e)
        {
            ListView listView = (sender as Button).Tag as ListView;

            string taskName = GetTaskNameFromUserInput("Enter Task Name", "Add Card to Done");
            if (!string.IsNullOrEmpty(taskName))
            {
                listView.Items.Add(taskName);
            }
        }


        private void addListButton_Click(object sender, EventArgs e)
        {
            string newListName = Interaction.InputBox("Enter List Name", "Add New List");
            if (!string.IsNullOrEmpty(newListName))
            {
                ListView newList = new ListView();
                newList.HideSelection = false;

                newList.Tag = newListName;

                newList.Location = new System.Drawing.Point(this.Controls.Cast<Control>().Max(c => c.Right) + 6, doneList.Location.Y);

                newList.Margin = new System.Windows.Forms.Padding(4);
                newList.Name = "newList" + (lists.Count + 1).ToString();
                newList.Size = doneList.Size;
                newList.TabIndex = 4;
                newList.UseCompatibleStateImageBehavior = false;
                newList.View = View.List;

                newList.Click += List_Click;
                newList.AllowDrop = true;
                newList.ItemDrag += List_ItemDrag;
                newList.DragEnter += List_DragEnter;
                newList.DragDrop += List_DragDrop;

                this.Controls.Add(newList);
                lists.AddLast(newList);

                Button addTaskToListButton = new Button();
                addTaskToListButton.Text = "Add Card";
                addTaskToListButton.Location = new System.Drawing.Point(newList.Location.X, newList.Location.Y + newList.Height + 6);
                addTaskToListButton.Size = new System.Drawing.Size(202, 23);
                addTaskToListButton.Margin = new System.Windows.Forms.Padding(4);
                addTaskToListButton.Tag = newList;
                addTaskToListButton.Click += AddTaskToListButton_Click;
                this.Controls.Add(addTaskToListButton);

                Label newLabel = new Label();
                newLabel.AutoSize = true;
                newLabel.Location = new System.Drawing.Point(newList.Location.X, 0);
                newLabel.Name = "label" + newList.Name;
                newLabel.Size = new System.Drawing.Size(25, 16);
                newLabel.TabIndex = 2;
                newLabel.Text = newListName;
                this.Controls.Add(newLabel);

                this.Height += newList.Height;


            }
        }

        private void AddTaskToListButton_Click(object sender, EventArgs e)
        {
            ListView listView = (sender as Button).Tag as ListView;

            string currentNewListName = listView.Tag.ToString();

            string newTask = Interaction.InputBox("Enter Task Name", "Add Card to" + " " + currentNewListName);
            if (!string.IsNullOrEmpty(newTask))
            {
                listView.Items.Add(newTask);
            }
        }

        private void List_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListView list = sender as ListView;
            list.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void List_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void List_DragDrop(object sender, DragEventArgs e)
        {
            ListView destinationList = sender as ListView;
            ListViewItem draggedItem = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
            ListView sourceList = draggedItem.ListView;

            if (sourceList != destinationList)
            {
                draggedItem.Remove();
                destinationList.Items.Add(draggedItem);
            }
        }



        private void removeTaskButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in selectedItems)
            {
                selectedItem.Remove();
            }
            selectedItems.Clear();
        }
    }
}


