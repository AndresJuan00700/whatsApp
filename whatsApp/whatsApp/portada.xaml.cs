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
                new Student {FirstName = "Andres", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", mensaje= "descripcion" },
                new Student {FirstName = "Maria", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",mensaje = "maria@cecdar" },
                new Student {FirstName = "Pepe", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", mensaje= "pepe" },
                new Student {FirstName = "Lina", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", mensaje= "lina@cecar" },
                new Student {FirstName = "Andres", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", mensaje= "descripcion" },
                new Student {FirstName = "Maria", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",mensaje = "maria@cecdar" },
                new Student {FirstName = "Pepe", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",mensaje = "pepe" },
                new Student {FirstName = "Lina", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",mensaje = "lina@cecar" },
                new Student {FirstName = "Andres", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", mensaje= "descripcion" },
                new Student {FirstName = "Maria", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",mensaje = "maria@cecdar" },
                new Student {FirstName = "Pepe", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", mensaje= "pepe" },
                new Student {FirstName = "Lina", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",mensaje = "lina@cecar" }
            };

            this.BindingContext = this;
        }





    }




    }
