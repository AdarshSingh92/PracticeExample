using FactoryDesignPattern;

CarFactory carFactory = new CarFactory();

ICar sedonCar = carFactory.CreateCarInstance("sedon");
sedonCar.GetCardDetails();
ICar SUVCar = carFactory.CreateCarInstance("SUV");
SUVCar.GetCardDetails();
