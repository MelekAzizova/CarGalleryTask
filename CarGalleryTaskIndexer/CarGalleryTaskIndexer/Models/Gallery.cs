namespace CarGalleryTaskIndexer.Models;

public class Gallery
{
    public string Name { get; set; }
    public Car[] cars;

    public Gallery()
    {
        cars=new Car[0];
    }


    public void AddCar(Car car)
    {
        Array.Resize(ref cars, cars.Length + 1);
        cars[cars.Length - 1] = car;

    }


    public Car this[int index]
    {
        get => cars[index];
        set => cars[index] = value;
    }

    public bool this[string name]
    {
        get
        {
            foreach (Car item in cars)
            {
                if (item.Name == name)
                {
                    return true;
                }


            }
            return false;
        }
        
    }












}
