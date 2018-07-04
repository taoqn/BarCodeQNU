using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BarcodeQNU.Component
{
    public enum VisibilityButton : byte
    {
        Visible = 0,
        HiddenOK = 1,
        HiddenCancel = 2,
        HiddenOKCancel = 3,
        HiddenClose = 4,
        HiddenAll = 5
    }
    /// <summary>
    /// Interaction logic for ModalDialog.xaml
    /// </summary>
    /// 
    [ContentProperty(nameof(Children))]
    public partial class ModalDialog : UserControl
    {
        public UIElementCollection Children
        {
            get { return (UIElementCollection)GetValue(ChildrenProperty.DependencyProperty); }
            private set { SetValue(ChildrenProperty, value); }
        }
        public static readonly DependencyPropertyKey ChildrenProperty = DependencyProperty.RegisterReadOnly(nameof(Children), typeof(UIElementCollection), typeof(ModalDialog), new PropertyMetadata());
        public string HeaderText
        {
            get => (string)GetValue(HeaderText_Property);
            set => SetValue(HeaderText_Property, value);
        }
        public static readonly DependencyProperty HeaderText_Property = DependencyProperty.Register("HeaderText", typeof(string), typeof(ModalDialog), new PropertyMetadata(string.Empty));
        public string Context_OK
        {
            get => (string)GetValue(Context_OK_Property);
            set => SetValue(Context_OK_Property, value);
        }
        public static readonly DependencyProperty Context_OK_Property = DependencyProperty.Register("Context_OK", typeof(string), typeof(ModalDialog), new PropertyMetadata("Xong"));
        public string Context_Cancel
        {
            get => (string)GetValue(Context_Cancel_Property);
            set => SetValue(Context_Cancel_Property, value);
        }
        public static readonly DependencyProperty Context_Cancel_Property = DependencyProperty.Register("Context_Cancel", typeof(string), typeof(ModalDialog), new PropertyMetadata("Hủy"));
        public VisibilityButton ShowButtonFooter
        {
            get => (VisibilityButton)GetValue(ShowButtonFooter_Property);
            set => SetValue(ShowButtonFooter_Property, value);
        }
        public static readonly DependencyProperty ShowButtonFooter_Property = DependencyProperty.Register("ShowButtonFooter", typeof(VisibilityButton), typeof(ModalDialog), new PropertyMetadata(VisibilityButton.Visible));
        public bool SetFullScreen
        {
            get => (bool)GetValue(SetFullScreen_Property);
            set => SetValue(SetFullScreen_Property, value);
        }
        public static readonly DependencyProperty SetFullScreen_Property = DependencyProperty.Register("SetFullScreen", typeof(bool), typeof(ModalDialog), new PropertyMetadata(false));
        public Thickness MarginDialog
        {
            get => (Thickness)GetValue(MarginDialog_Property);
            set => SetValue(MarginDialog_Property, value);
        }
        public static readonly DependencyProperty MarginDialog_Property = DependencyProperty.Register("MarginDialog", typeof(Thickness), typeof(ModalDialog), new PropertyMetadata(new Thickness(0, 30, 0, 0)));
        //
        public int ParamIndex { get => _paramIndex; set => this._paramIndex = value; }
        private int _paramIndex;
        private FrameworkElement _parent;
        // events
        public event RoutedEventHandler OKModal;
        public event RoutedEventHandler CloseModal;
        public event RoutedEventHandler ExitAllModal;
        // Initalizations
        public ModalDialog()
        {
            InitializeComponent();
            Children = ModalContainer.Children;
            Visibility = Visibility.Hidden;
        }
        private void root_Loaded(object sender, RoutedEventArgs e)
        {
            Thickness thickness = new Thickness(0, 0, 0, 0);
            if (SetFullScreen)
            {
                BorderContainer.Margin = thickness;
                BorderContainer.VerticalAlignment = VerticalAlignment.Center;
            }
            if (ShowButtonFooter == VisibilityButton.HiddenOK)
            {
                OkButton.Visibility = Visibility.Hidden;
                OkButton.Height = 0;
                OkButton.Width = 0;
                OkButton.Margin = thickness;
                return;
            }
            if (ShowButtonFooter == VisibilityButton.HiddenCancel)
            {
                CancelButton.Visibility = Visibility.Hidden;
                CancelButton.Height = 0;
                CancelButton.Width = 0;
                CancelButton.Margin = thickness;
                return;
            }
            if (ShowButtonFooter == VisibilityButton.HiddenAll || ShowButtonFooter == VisibilityButton.HiddenClose || ShowButtonFooter == VisibilityButton.HiddenOKCancel)
            {
                if (ShowButtonFooter == VisibilityButton.HiddenAll || ShowButtonFooter == VisibilityButton.HiddenClose)
                {
                    CloseButton.Visibility = Visibility.Hidden;
                    CloseButton.Width = 0;
                    HeaderLabel.Margin = thickness;
                }
                if (ShowButtonFooter == VisibilityButton.HiddenAll || ShowButtonFooter == VisibilityButton.HiddenOKCancel)
                {
                    grid_button.Visibility = Visibility.Hidden;
                    grid_button.Margin = thickness;
                    OkButton.Height = 0;
                    OkButton.Width = 0;
                    OkButton.Margin = thickness;
                    CancelButton.Height = 0;
                    CancelButton.Width = 0;
                    CancelButton.Margin = thickness;
                }
                return;
            }
        }
        public void SetParent(FrameworkElement parent)
        {
            _parent = parent;
            _parent.SizeChanged += _parent_SizeChanged;
        }
        private void _parent_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (SetFullScreen)
            {
                ModalContainer.Width = (e.NewSize.Width - 50);
                ModalContainer.Height = (e.NewSize.Height - 130);
            }
        }
        public void ShowHandlerDialog()
        {
            Visibility = Visibility.Visible;
            _parent.IsEnabled = false;
        }
        public void HideHandlerDialog()
        {
            Visibility = Visibility.Hidden;
            _parent.IsEnabled = true;
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            OKModal?.Invoke(sender, e);
            HideHandlerDialog();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            CloseModal?.Invoke(sender, e);
            HideHandlerDialog();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ExitAllModal?.Invoke(sender, e);
            HideHandlerDialog();
        }
    }
}
