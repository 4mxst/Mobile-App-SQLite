using System;
using System.Windows.Input;
using PropertyChanged;
using MauiAppSQLite.MVVM.Model;


namespace MauiAppSQLite.ViewModels;


[AddINotifyPropertyChangedInterface]
public class CarPageViewModel
{
    public List<Car> Cars { get; set; }
    public Car CurrentCar { get; set; }
    public ICommand AddOrUpdateCommand { get; set; }
    public ICommand DeleteCommand { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public CarPageViewModel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        this.Refresh();
        AddOrUpdateCommand = new Command(async () =>
        {
            App._carRepo.AddOrUpdate(CurrentCar);
            Console.WriteLine(App._carRepo.StatusMessage);
            this.Refresh();
        });

        DeleteCommand = new Command(async () => {
            App._carRepo.Delete(CurrentCar.ID);
            this.Refresh();
        });
    }
    private void Refresh()
    {
        CurrentCar = new Car();

        this.Cars = App._carRepo.GetAll();
    }
}
