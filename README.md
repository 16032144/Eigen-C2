# Eigen-C2

Deze C2-framework gebouwd aan de hand van C# (Agent) en PHP/MYSQL (Server)

## C2-Agent
1) Download de bestanden van de Agent map
2) Compileer deze aan de hand van Visual Studio Code

### VirusTotal Detection rate:
Óndanks dat er niet speficiek aandacht besteed is aan het vermijden van detectie, wordt dit framework maar door één Antivirus opgepakt.
![Resulaat van Virustotal](/2021-05-01%2017_51_41-VirusTotal.png)

## C2-Server
Om de server werkend te krijgen, moet de gebruiker:
1) Apache installeren & configureren
2) MYSQL server installeren & configureren

### Apache server
1) Installer Apache webserver
2) Download bestanden uit de Server map.
3) Kopieer de bestanden naar de rootmap van de webserver.
4) Start de server.

### MYSQL database
1) Installeer Mysql database 
2) Start Mysql database.
3) Login op de database.
4) Creeër de volgende database: ControlPanel.
5) Creeër in de database "ControlPanel" twee tabellen: users & victims.
6) Tabel user bevat de volgende drie kolommen:

| Field    | Type         | Null | Key | Default | Extra          |
|----------|--------------|------|-----|---------|----------------|
| id       | int(11)      | NO   | PRI | NULL    | auto_increment |
| username | varchar(255) | YES  |     | NULL    |                |
| password | varchar(255) | YES  |     | NULL    |                |

7) Tabel victims bevat de volgende zes kolommen:

| Field           | Type         | Null | Key | Default | Extra          |
|-----------------|--------------|------|-----|---------|----------------|
| id              | int(11)      | NO   | PRI | NULL    | auto_increment |
| hostname        | varchar(255) | YES  |     | NULL    |                |
| ipaddress       | varchar(255) | YES  |     | NULL    |                |
| operatingsystem | varchar(255) | YES  |     | NULL    |                |
| command         | text         | YES  |     | NULL    |                |
| commandresult   | longtext     | YES  |     | NULL    |                |
