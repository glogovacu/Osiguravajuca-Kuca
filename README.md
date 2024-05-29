**[Read this in English / Kliknite ovde za englesku verziju](README.en.md)**
# Informacioni sistem za prodaju polisa osiguranja
## Pregled
Ovaj projekat predstavlja informacioni sistem za osiguravajuću kuću specijalizovanu za prodaju polisa osiguranja.
## Uvod
Sistem omogućava novim klijentima da se registruju, konsultuju sa agentima osiguranja, biraju polise, izračunavaju premije, upravljaju svojim polisama online i podnose zahteve za štetu. Ključne funkcionalnosti uključuju:
* **Registracija Klijenta**: Novi klijenti se registruju pružanjem ličnih podataka.
* **Konsultacija**: Klijenti mogu da se konsultuju sa agentima putem telefona, online chat-a ili zakazivanjem sastanaka.
* **Izbor Polise**: Klijenti biraju odgovarajuće polise na osnovu svojih potreba.
* **Izračunavanje Premije**: Agenti izračunavaju premije na osnovu različitih faktora.
* **Upravljanje Polisama**: Klijenti mogu da upravljaju svojim polisama online.
* **Postupak Štete**: Klijenti mogu da podnose zahteve za štetu u slučaju nepredviđenih događaja.
## UML Modelovanje
### Use Case Dijagram
Use case dijagram prikazuje interakcije između klijenata (novih i registrovanih) i agenata. Dijagram uključuje registraciju, izbor polise, zakazivanje konsultacija i podnošenje zahteva za štetu.

![image3](https://github.com/glogovacu/Osiguravajuca-Kuca/assets/125755319/9049fd92-365d-4033-a704-cf8ef354462f)

### Dijagram Sekvenci
#### Sekvenca Interakcije Agenta:
* Agent se prijavljuje u aplikaciju.
* Prikazuju se podaci i zakazuju se sastanci.
* Izračunava se premija.
#### Sekvenca Interakcije Klijenta:
* Klijent se prijavljuje ili registruje.
* Prikazuju se polise.
* Klijent zakazuje sastanke ili podnosi zahteve za štetu.

![image5](https://github.com/glogovacu/Osiguravajuca-Kuca/assets/125755319/6adcf028-56d4-4acb-b89d-8bf8e3455664)

### Dijagram Aktivnosti
Dijagram aktivnosti prikazuje proces prijave klijenta, zakazivanja sastanaka i podnošenja zahteva za štetu.

![image19](https://github.com/glogovacu/Osiguravajuca-Kuca/assets/125755319/49e6e7c2-d820-4817-afa6-34a537cbdd49)

## Baza podataka
### Konceptualni model

![image16](https://github.com/glogovacu/Osiguravajuca-Kuca/assets/125755319/77b9577b-e7ec-4ed6-96ad-f0bf0ec582c2)

### Fizicki model

![image10](https://github.com/glogovacu/Osiguravajuca-Kuca/assets/125755319/c7d8e1e0-ef60-482f-ad4c-7195cbcd45cc)

## Implementacija
Sistem je implementiran korišćenjem C# i .NET Framework-a, sa Microsoft SQL Server 2022 kao bazom podataka.
## Testirnje
Ako u svojoj bazi podataka ubacite kredencijale za agenta mozete da pristupite agent screenu.
### Login Screen

![image8](https://github.com/glogovacu/Osiguravajuca-Kuca/assets/125755319/cd1a6ad6-dfe0-4aa1-a6a6-b1c912047d12)

### Agent Screen

![image2](https://github.com/glogovacu/Osiguravajuca-Kuca/assets/125755319/06e075f2-eda7-4cf8-ac47-c01ffdb1ca88)

## Reference 
- [SQL Server with C# Windows Forms App](https://www.youtube.com/watch?v=rXugzELsQl0)
- [Establishing The Connection](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/establishing-the-connection) 
