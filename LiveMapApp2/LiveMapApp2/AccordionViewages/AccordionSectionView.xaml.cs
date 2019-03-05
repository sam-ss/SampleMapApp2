using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiveMapApp2.AccordionViewages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccordionSectionView : ContentPage
	{
        #region Bindable Properties
        public static BindableProperty HeaderBackgroundColorProperty =
            BindableProperty.Create(nameof(HeaderBackgroundColor),
                typeof(Color),
                typeof(AccordionSectionView),
                defaultValue: Color.Transparent,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    ((AccordionSectionView)bindable).UpdateHeaderBackgroundColor();
                });

        public static BindableProperty HeaderOpenedBackgroundColorProperty =
            BindableProperty.Create(nameof(HeaderOpenedBackgroundColor),
                typeof(Color),
                typeof(AccordionSectionView),
                defaultValue: Color.Transparent,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    ((AccordionSectionView)bindable).UpdateHeaderBackgroundColor();
                });

        public static BindableProperty HeaderTextColorProperty =
            BindableProperty.Create(nameof(HeaderTextColor),
                typeof(Color),
                typeof(AccordionSectionView),
                defaultValue: Color.Black,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    ((AccordionSectionView)bindable).UpdateHeaderTextColor((Color)newVal);
                });

        public static BindableProperty HeaderTextProperty =
            BindableProperty.Create(nameof(HeaderTextProperty),
                typeof(string),
                typeof(AccordionSectionView),
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    ((AccordionSectionView)bindable).UpdateHeaderText((string)newVal);
                });

        public static BindableProperty BodyTextColorProperty =
            BindableProperty.Create(nameof(BodyTextColor),
                typeof(Color),
                typeof(AccordionSectionView),
                defaultValue: Color.Black,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    ((AccordionSectionView)bindable).UpdateBodyTextColor((Color)newVal);
                });

        public static BindableProperty BodyTextProperty =
            BindableProperty.Create(nameof(BodyText),
                typeof(string),
                typeof(AccordionSectionView),
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    ((AccordionSectionView)bindable).UpdateBodyText((string)newVal);
                });


        public static BindableProperty IsBodyVisibleProperty =
            BindableProperty.Create(nameof(IsBodyVisible),
                typeof(bool),
                typeof(AccordionSectionView),
                defaultValue: true,
                propertyChanged: (bindable, oldVal, newVal) =>
                {
                    ((AccordionSectionView)bindable).UpdateBodyVisibility((bool)newVal);
                });
        #endregion

        #region Public Properties
        public Color HeaderBackgroundColor
        {
            get
            {
                return (Color)GetValue(HeaderBackgroundColorProperty);
            }
            set
            {
                SetValue(HeaderBackgroundColorProperty, value);
            }
        }
        public Color HeaderOpenedBackgroundColor
        {
            get
            {
                return (Color)GetValue(HeaderOpenedBackgroundColorProperty);
            }
            set
            {
                SetValue(HeaderOpenedBackgroundColorProperty, value);
            }
        }
        public Color HeaderTextColor
        {
            get
            {
                return (Color)GetValue(HeaderTextColorProperty);
            }
            set
            {
                SetValue(HeaderTextColorProperty, value);
            }
        }
        public string HeaderText
        {
            get
            {
                return (string)GetValue(HeaderTextProperty);
            }
            set
            {
                SetValue(HeaderTextProperty, value);
            }
        }
        public Color BodyTextColor
        {
            get
            {
                return (Color)GetValue(BodyTextColorProperty);
            }
            set
            {
                SetValue(BodyTextColorProperty, value);
            }
        }
        public string BodyText
        {
            get
            {
                return (string)GetValue(BodyTextProperty);
            }
            set
            {
                SetValue(BodyTextProperty, value);
            }
        }

        public bool IsBodyVisible
        {
            get
            {
                return (bool)GetValue(IsBodyVisibleProperty);
            }
            set
            {
                SetValue(IsBodyVisibleProperty, value);
            }
        }

        #endregion


        public AccordionSectionView()
        {
            InitializeComponent();
            IsBodyVisible = false;
            if (Resources != null)
            {
               // Resources.MergedWith = typeof(PrimaryTheme);
            }
            else
            {
                Resources = new ResourceDictionary
                {
                 //   MergedWith = typeof(PrimaryTheme)
                };
            }
        }

        /// <summary>
        /// Updates the color of the header background.
        /// </summary>
        /// <param name="color">Color.</param>
        public void UpdateHeaderBackgroundColor(Color color)
        {
            HeaderView.BackgroundColor = color;
        }

        /// <summary>
        /// Updates the color of the header background.
        /// </summary>
        public void UpdateHeaderBackgroundColor()
        {
            if (IsBodyVisible)
            {
                HeaderView.BackgroundColor = HeaderOpenedBackgroundColor;
                BodyView.BackgroundColor = HeaderOpenedBackgroundColor;
            }
            else
            {
                HeaderView.BackgroundColor = HeaderBackgroundColor;
            }
        }

        /// <summary>
        /// Updates the color of the header text.
        /// </summary>
        /// <param name="color">Color.</param>
        public void UpdateHeaderTextColor(Color color)
        {
            HeaderLabel.TextColor = color;
        }

        /// <summary>
        /// Updates the color of the body text.
        /// </summary>
        /// <param name="color">Color.</param>
        public void UpdateBodyTextColor(Color color)
        {
            BodyLabel.TextColor = color;
        }

        /// <summary>
        /// Updates the header text.
        /// </summary>
        /// <param name="text">Text.</param>
        public void UpdateHeaderText(string text)
        {
            HeaderLabel.Text = text;
        }

        /// <summary>
        /// Updates the body text.
        /// </summary>
        /// <param name="text">Text.</param>
        public void UpdateBodyText(string text)
        {
            BodyLabel.Text = text;
        }

        public void UpdateBodyVisibility(bool isVisible)
        {
            BodyView.IsVisible = isVisible;
            IndicatorLabel.Text = "+";
            if (isVisible)
            {
                IndicatorLabel.RotateTo(45, 100);
            }
            else
            {
                IndicatorLabel.RotateTo(0, 100);
            }
        }

        private void Handle_Tapped(object sender, System.EventArgs e)
        {
            IsBodyVisible = !IsBodyVisible;
            UpdateHeaderBackgroundColor();
        }
    }
}