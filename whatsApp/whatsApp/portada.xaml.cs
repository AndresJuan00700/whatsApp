using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace whatsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class portada : TabbedPage
    {
        public ObservableCollection<Student> Students { get; set; }
        public portada()
        {
            InitializeComponent();

            Students = new ObservableCollection<Student>
            {
                new Student {FirstName = "Andres", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "andres.bertel@cecar.com" },
                new Student {FirstName = "Maria", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "maria@cecdar" },
                new Student {FirstName = "Pepe", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "pepe" },
                new Student {FirstName = "Lina", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "lina@cecar" },
                new Student {FirstName = "Andres", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "andres.bertel@cecar.com" },
                new Student {FirstName = "Maria", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "maria@cecdar" },
                new Student {FirstName = "Pepe", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "pepe" },
                new Student {FirstName = "Lina", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "lina@cecar" },
                new Student {FirstName = "Andres", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "andres.bertel@cecar.com" },
                new Student {FirstName = "Maria", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "maria@cecdar" },
                new Student {FirstName = "Pepe", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "pepe" },
                new Student {FirstName = "Lina", Lastname= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", Email = "lina@cecar" }
            };

            this.BindingContext = this;
        }





    }




    }
