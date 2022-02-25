## Units.NET "Classes"
### Fork of Units.NET where structs were replaced with classes, complex value support was added, and arbitrary arithmetic support was added.
### Note that this is for educational purposes as a proof of concept.


### Arbitrary Arithmetic

```C#
ElectricResistance r = new ElectricResistance(2, ElectricResistanceUnit.Ohm);
ElectricCurrent i = new ElectricCurrent(4, ElectricCurrentUnit.Ampere);

ApparentPower p = (ApparentPower)(i * i * r);
```

### Complex Arithmetic

```C#
ElectricPotential v = new ElectricPotential(new Complex(10, 4), ElectricPotentialUnit.Volt);
ElectricCurrent i = new ElectricCurrent(new Complex(2, 8), ElectricCurrentUnit.Ampere);

ApparentPower p = (ApparentPower)(v * i.Conjugate);
```
