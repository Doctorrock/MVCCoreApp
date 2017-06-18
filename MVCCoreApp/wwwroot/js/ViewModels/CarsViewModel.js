function Car(name, wheels, basePrice,wheelPrice) {
    var self = this;
    self.name = name;
    self.wheels = wheels;
    self.basePrice = basePrice;
    self.wheelPrice = wheelPrice;

    self.totalPrice = ko.computed(function() {
        var price = self.basePrice() + self.wheels() * self.wheelPrice();
        return price;
    });
}

function CarsListViewModel() {
    var self = this;
    self.cars = ko.observableArray();

    self.addCar = function() {
        self.cars.push(new Car("", 0, 0, 0));
    }

}

ko.applyBindings(new CarsListViewModel());