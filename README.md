<!-- Logo -->
<p align="center">
  <a href="#">
    <img height="128" width="128" src="https://raw.githubusercontent.com/0xF6/Quark/master/icon/icon.png">
  </a>
</p>

<!-- Name -->
<h1 align="center">
  Elementary Quark Lib 🔅
</h1>
<p align="center">
  <a href="#">
    <img alr="MIT License" src="http://img.shields.io/:license-MIT-blue.svg">
    <img alt="Quark release" src="https://img.shields.io/github/release/0xF6/Quark.svg">
    <img alt="Quark Status build" src="https://github.com/ElementaryStudio/Quark/workflows/.NET%20Core%20CI/badge.svg">
  </a>
  <a href="https://www.nuget.org/packages/Elementary.Quarks/">
    <img alt="Nuget" src="https://img.shields.io/nuget/v/Elementary.Quarks.svg?color=%23884499">
  </a>
  <a href="https://t.me/ivysola">
    <img alt="Telegram" src="https://img.shields.io/badge/Ask%20Me-Anything-1f425f.svg">
  </a>
<a href="https://app.fossa.io/projects/git%2Bgithub.com%2FElementaryStudio%2FQuark?ref=badge_shield" alt="FOSSA Status"><img src="https://app.fossa.io/api/projects/git%2Bgithub.com%2FElementaryStudio%2FQuark.svg?type=shield"/></a>
</p>
<p align="center">
  <a href="#">
    <img src="https://forthebadge.com/images/badges/made-with-c-sharp.svg">
    <img src="https://forthebadge.com/images/badges/designed-in-ms-paint.svg">
    <img src="https://forthebadge.com/images/badges/ages-18.svg">
    <img src="https://ForTheBadge.com/images/badges/winter-is-coming.svg">
    <img src="https://forthebadge.com/images/badges/gluten-free.svg">
  </a>
</p>


Remark:       
  `This project is part of a closed project ElementarySandbox`    


### Install   
`dotnet add package Elementary.Quarks --version 2.0.6`


# API

Remark: 
```asm
- Quark is a implement IComparable, IComparable<Quark> and IEquatable<Quark> interface;
- Quark is a native marshaling compatible;
- Quark is a gota go fast structure;
```


### ElectricChange

Base parse:
```CSharp
var e = ElectricChange.Token.Parse("+(1/2)") 
// has return new object
{
  IsPositive: true,
  Numerator: 1,
  Denominator: 2
}

e.ToString() // -> ["+(1/2)ℯ"]
```

### Spin

Base parse:
```CSharp
var e = Spin.Token.Parse("(1/2)") 
// has return new object
{
  Numerator: 1,
  Denominator: 2
}

e.ToString() // -> ["(1/2)ħ"]
```

### Quark


Support: `u d s c b t` quarks, and anti-quark `ū d̄ s̄ c̄ b̄ t̄`

Base parse:
```CSharp

var qList = Quark.Token.Parse("[u|u|d]") // uud a quark structure of proton

qList.First().ToString() // -> [u +(2/3)ℯ 2.3 MeV/c²]


qList.First()
// ->
{
  Mass: { Value: 2.3, Unit: 'MegaElectronVolt'  }
  Symbol: 'u',
  Type: TopQuark,
  EChange: "+(2/3)"
}


// Also supported antiquark

var antiquark = Quark.Token.Parse("[-u]").First()

antiquark.ToString() // -> [ū -(2/3)ℯ 2.3 MeV/c²]
antiquark.IsAnti() // -> True
```




[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2FElementaryStudio%2FQuark.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2FElementaryStudio%2FQuark?ref=badge_large)
