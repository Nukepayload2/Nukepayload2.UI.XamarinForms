using Nukepayload2.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nukepayload2.UI.XamarinForms.Gallery
{
    public partial class MainPage : ContentPage
    {
        public TimelineModelCollection TimelineList { get; } = new TimelineModelCollection();

        private TimelineModelBase _selectedTimelineItem;
        public TimelineModelBase SelectedTimelineItem
        {
            get
            {
                return _selectedTimelineItem;
            }
            set
            {
                _selectedTimelineItem = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();
            EditBoxDemo.Click += EditBoxDemo_ClickAsync;
            BtnRandomContent.Clicked += BtnRandomContent_Clicked;
            CtlTimeline.AddActionRequested += CtlTimeline_AddActionRequested;
            CtlTimeline.AddDateRequested += CtlTimeline_AddDateRequested;
            CtlTimeline.AddTimeRequested += CtlTimeline_AddTimeRequested;
            CtlTimeline.UndoRequested += CtlTimeline_UndoRequested;
            CtlTimeline.RedoRequested += CtlTimeline_RedoRequested;
            CtlTimeline.DeleteRequested += CtlTimeline_DeleteRequested;
            CtlTimeline.MoveUpRequested += CtlTimeline_MoveUpRequested;
            CtlTimeline.MoveDownRequested += CtlTimeline_MoveDownRequested;
            LstItems.ItemsSource = _randomItems;
            BindingContext = this;
        }

        private void CtlTimeline_MoveDownRequested(object sender, EventArgs e)
        {
            var item = SelectedTimelineItem;
            if (item != null)
            {
                var id = TimelineList.IndexOf(item);
                if (id < TimelineList.Count - 1)
                {
                    TimelineList.Move(id, id + 1);
                }
            }
        }

        private void CtlTimeline_MoveUpRequested(object sender, EventArgs e)
        {
            var item = SelectedTimelineItem;
            if (item != null)
            {
                var id = TimelineList.IndexOf(item);
                if (id > 0)
                {
                    TimelineList.Move(id, id - 1);
                }
            }
        }

        private void CtlTimeline_DeleteRequested(object sender, EventArgs e)
        {
            var item = SelectedTimelineItem;
            if (item != null)
            {
                TimelineList.Remove(item);
            }
        }

        private void CtlTimeline_RedoRequested(object sender, EventArgs e)
        {

        }

        private void CtlTimeline_UndoRequested(object sender, EventArgs e)
        {

        }

        private void CtlTimeline_AddTimeRequested(object sender, EventArgs e)
        {
            TimelineList.Add(new TimelineTime() { Time = DateTime.Now.TimeOfDay });
        }

        private void CtlTimeline_AddDateRequested(object sender, EventArgs e)
        {
            TimelineList.Add(new TimelineDate() { Date = DateTime.Now });
        }

        private void CtlTimeline_AddActionRequested(object sender, EventArgs e)
        {
            TimelineList.Add(new TimelineAction() { Action = TimelineActionIcons.Dinner, Description = "跟我的小甜甜五吃饭。" });
        }

        public string DemoText { get => _demoText; set { _demoText = value; OnPropertyChanged(); } }
        private ColorItem _selectedColor = new ColorItem(Color.Black, nameof(Color.Black));
        public ColorItem SelectedColor
        {
            get
            {
                return _selectedColor;
            }
            set
            {
                _selectedColor = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ColorItem> Colors { get; } = from c in typeof(Color).GetRuntimeFields()
                                                        where c.IsStatic && !c.IsSpecialName && c.IsPublic
                                                        select new ColorItem((Color)c.GetValue(default), c.Name);

        private ObservableCollection<object> _randomItems = new ObservableCollection<object>();
        private int _itemCounter = 1;
        private string _demoText = "你";

        private void BtnRandomContent_Clicked(object sender, EventArgs e)
        {
            _randomItems.Add(new { Header = $"项目{_itemCounter++}", Text = Guid.NewGuid().ToString() });
        }

        private async void EditBoxDemo_ClickAsync(object sender, EventArgs e)
        {
            if (EditBoxDemo.IsEditing)
            {
                EditBoxDemo.IsSaving = true;
                await Task.Delay(500);
                EditBoxDemo.IsSaving = false;
                EditBoxDemo.IsEditing = false;
            }
            else
            {
                EditBoxDemo.IsEditing = true;
            }
        }
    }
}
