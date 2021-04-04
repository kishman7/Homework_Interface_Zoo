using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_Zoo
{
    class VideoCamera : IWatch
    {
        public string Animal { get; set; }
        public string NameCamera { get; set; }
        public VideoCamera(string nameCamera, string animal)
        {
            NameCamera = nameCamera;
            Animal = animal;
        }
        public void Watch()
        {
            Console.WriteLine($"Camera {NameCamera} watch on the {Animal}");
        }
    }
}
