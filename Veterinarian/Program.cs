using Veterinarian;

Veterinarians veterinarians = new Veterinarians();
Cat cat = new Cat();
Dog dog = new Dog();
Horse horse = new Horse();
Animal[] animal = new Animal[] {cat,dog,horse};
for (int i = 0; i < animal.Length; i++)
{
    veterinarians.TreateAnimal(animal[i]);  
}