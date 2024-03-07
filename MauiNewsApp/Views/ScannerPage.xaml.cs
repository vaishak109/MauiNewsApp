#if ANDROID
using AndroidX.Camera.Lifecycle;
#endif
using System.Reflection;
using ZXing.Net.Maui;

namespace MauiNewsApp.Views;

public partial class ScannerPage : ContentPage
{
    public ScannerPage()
    {
        InitializeComponent();
        Console.WriteLine("ScannerPage initialized");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        barcodeView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.All,
            AutoRotate = true,
            Multiple = true
        };
        barcodeView.CameraLocation = barcodeView.CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;
        barcodeView.CameraLocation = barcodeView.CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;
    }

    protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            lb1.Text = "";
            lbl2.Text = $"{e.Results[0].Format}->{e.Results[0].Value}";
            barcodeView.IsDetecting = false;
        });
    }

    private void OnFlashBtnClicked(object sender, EventArgs e)
    {

        if (barcodeView.IsTorchOn)
        {
            flashBtnImg.Glyph = "\uf00b";
            barcodeView.IsTorchOn = false;
        }
        else
        {
            flashBtnImg.Glyph = "\uf00a";
            barcodeView.IsTorchOn = true;
        }


    }

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    Console.WriteLine("ScannerPage OnAppearing");
    //    barcodeView.IsEnabled = true;
    //    barcodeView.IsVisible = true;
    //}


    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        Console.WriteLine("ScannerPage OnDisappearing");
#if ANDROID
        // Get the camera manager
        Type type = barcodeView.Handler.GetType();
        FieldInfo fieldInfo = type.GetField("cameraManager", BindingFlags.NonPublic | BindingFlags.Instance);
        object value = fieldInfo.GetValue(barcodeView.Handler);

        // Get the ProcessCameraProvider
        type = value.GetType();
        fieldInfo = type.GetField("cameraProvider", BindingFlags.NonPublic | BindingFlags.Instance);
        ProcessCameraProvider cameraProvider = (ProcessCameraProvider)fieldInfo.GetValue(value);
        if (cameraProvider != null)
        {
            Console.WriteLine($"ScannerPage Camera {cameraProvider}");
            cameraProvider.UnbindAll();
        }
#endif
    }
}