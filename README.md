<p align="center">
  <img src=https://raw.githubusercontent.com/igtampe/ViBE/master/Resources/VIBESplash.png width="400"/><br>
</p>

ViBE or the Visual Basic Economy program is a client designed to aid the transactions of the Pecunia, NEXUS's Model Nation's (The UMS's) virtual currency. <br> <br> 

<p align="center">
  <img src=https://lh5.googleusercontent.com/Qg-TVDWy1DhuO-5l8dKnhcNstueZKQL24OwXquBbDfKETXNMdrDY2G2vy0CdT00RftWAeNz74tk08n0vCSlIWfJdWphY7IK-R3CRKhWyeuEzM05n94s=w1280 /><br>
</p>

ViBE relies entirely on the SmokeSignal framework, which was originally created specifically for ViBE. It communicates with the ViBE Server, which is viewable here (https://github.com/igtampe/VibeServer). <br><br> 

## Subprograms
ViBE also contains small subprograms, including the following:<br><br>

### EzTax
EzTax helps users set their income (Which they receive monthly on the first of the month) and to view the tax they're set to be automatically billed (which also occurs monthly, but on the 15th.) EzTax communicates with the ViBE Server's ViBE SuperExtension to update and retrieve income, but also uses LBL (See LBL Sender for an explanation of LBL) to upload user's local Income Registry Files to the server for backup, as well as contacting the IMEX extension to know wether its tax deffinitions are out of date. <br><br>

### Checkbook 2000
Checkbook 2000 manages the sending of checks and bills to other users, though the actual transfer of money is handled by ViBE's Send function. Checkbook works by communicating with the ViBE Super Extension's CHKBK portion.

### LandView
Landview is actually rather independent from other parts of ViBE, and is essentially only used to access and parse a small database of terrains within the UMS. LandView is rather limited in functionality, however a rework that actually allows users to purchase terrain using it, as well as to purchas non-listed plots by giving coordinates, may potentially occur sometime in the future.

### Contractus
Contractus manages the bidding and billing of contracts in the UMS, and communicates with its respective portion of the ViBE Super Extension. It's not really used much, but it still works.
