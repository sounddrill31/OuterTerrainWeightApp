using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace OuterTerrainWeightApp.Views;

public partial class MainView : UserControl
{
    public const double RatioEarth = 1.00D;
    public const double RatioMercury = 0.38D;
    public const double RatioMars = 0.38D;
    public const double RatioJupiter = 2.36D;
    public const double RatioSaturn = 0.92D;
    public const double RatioVenus = 0.90D;
    public const double RatioUranus = 0.89D;
    public const double RatioNeptune = 1.12D;
    public const double RatioMoon = 0.17D;

    public MainView()
    {
        InitializeComponent();
    }

    private void Button_OnClick_Exit(object? sender, RoutedEventArgs e)
    {
        System.Environment.Exit(0);
    }

    //W(Mars) = W(Earth) × g(Mars)/(g(Earth) 
    public static double CalcWeight(double WeightEarth, double PlanetRatio)
    {
        return (WeightEarth * PlanetRatio);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
    double weightEarth = Convert.ToDouble(EarthWeightString.Text);
    MerWeightString.Text = CalcWeight(weightEarth, RatioMercury).ToString();
    VenWeightString.Text = CalcWeight(weightEarth, RatioVenus).ToString();
    EarWeightString.Text = CalcWeight(weightEarth, RatioEarth).ToString();
    MarWeightString.Text = CalcWeight(weightEarth, RatioMars).ToString();
    JupWeightString.Text = CalcWeight(weightEarth, RatioJupiter).ToString();
    SatWeightString.Text = CalcWeight(weightEarth, RatioSaturn).ToString();
    UrWeightString.Text = CalcWeight(weightEarth, RatioUranus).ToString();
    NepWeightString.Text = CalcWeight(weightEarth, RatioNeptune).ToString(); 
    MoonWeightString.Text = CalcWeight(weightEarth, RatioMoon).ToString(); 

    }
}