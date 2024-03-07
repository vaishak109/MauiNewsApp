using MauiNewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiNewsApp.ViewModels
{
    public class LottieViewModel
    {
        public ICollection<String> LottieUrls { get; set; }
        public LottieViewModel()
        {
            Console.WriteLine("Lottie View Model initialized");
            LottieUrls = new List<String>
            {
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/A.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/B.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/C.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/D.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/E.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/F.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/G.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/H.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/I.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/J.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/K.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/L.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/M.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/N.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/O.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/P.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/Q.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/R.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/S.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/T.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/U.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/V.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/W.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/X.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/Y.json",
                "https://raw.githubusercontent.com/xvrh/lottie-flutter/master/example/assets/Mobilo/Z.json",
            };
        }
    }
}
