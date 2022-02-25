[![Build status](https://ci.appveyor.com/api/projects/status/f8qfnqd7enkc6o4k/branch/master?svg=true)](https://ci.appveyor.com/project/angularsen/unitsnet/history/branch/master) [![Join the chat at https://gitter.im/UnitsNet/Lobby](https://badges.gitter.im/UnitsNet/Lobby.svg)](https://gitter.im/UnitsNet/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![codecov](https://codecov.io/gh/angularsen/UnitsNet/branch/master/graph/badge.svg)](https://codecov.io/gh/angularsen/UnitsNet)

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
