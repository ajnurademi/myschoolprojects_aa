### Zusammenfassung M346



#### 

- Sie können Vor- und Nachteile der Cloud erläutern

Vorteile:

Reduzierter IT-Administrationsaufwand

Zeitnahe Skalierbarkeit der IT-Leistungen (Flexibilität)

Schnelle, günstige Implementierung neuer Anwendungen



Nachteile:

Abhängigkeit von externen Leistungen

Langfristige Kosten



- Sie können das Maturity-Modell erläutern



Classic

Virtualized

Cloud Ready

Cloud Native



- Sie können den Begriff Hypervisor erläutern

Der Hypervisor erstellt die Verbindung vom Server(Hardware) zu den einzelnen VMS die auf dem Server laufen. Mit dem Hypervisor kann man sie kontrollieren in dem der Hypervisor auf einem Betriebssystem lauft oder selbst zum Betriebssystem wird. 



- Sie können die Unterschiede von Virtualisierung zu Cloud erläutern

Ist eine Technologie

Simulierte Umgebungen auf einem Server

Virtualisierung ist die verteilung von VMS auf Server. Auf diesen VMS werden die Ressourcen vom Server auf die VMS aufgeteilt und über ein Hypervisor können diese VMS so kontrolliert werden, dass sie zusammen ihre Aufgabe erledigen. 



Ist eine Methode

Pooling und Automatisierung von viruellen Ressourcen nach bedarf. 

Bei Cloud wird alles auf externen Servern gelagert. Es läuft alles übers Internet und alle mit Zugang können übers Internet darauf zugreifen. 





- Gründe für die Virtualisierung erläutern

Partitionierung (die Ressourcen eines physikalischen Rechners werden auf mehrere VMs aufgeteilt)

Isolation (die VMs sind vom Host OS und untereinander komplett abgeschottet)

Kapselung (komplette Rechner mit ihrer Konfiguration werden in wenigen Dateien gebündelt)



- Sie können ssh PK-Auth erläutern
  
  SSH PK-Auth steht für "Public Key Authentication" bei SSH (Secure Shell). Es ist eine Methode zur Authentifizierung, bei der ein Benutzer einen privaten Schlüssel besitzt und einen zugehörigen öffentlichen Schlüssel auf einem Server speichert. Beim Verbindungsaufbau sendet der Benutzer seinen öffentlichen Schlüssel an den Server, der ihn mit dem auf dem Server gespeicherten öffentlichen Schlüssel vergleicht. Wenn die Schlüssel übereinstimmen, wird der Benutzer authentifiziert und erhält Zugriff. PK-Auth ist sicherer als Passwort-Authentifizierung, da keine Passwörter über das Netzwerk übertragen werden müssen und die Schlüssel nicht im Klartext gespeichert sind.
  
  

- Sie können das NIST-Modell erläutern, dazu gehört:  
  
  - Sie können die Servicemodelle IaaS, PaaS und SaaS erläutern und Beispiele dazu angeben
  - Sie können zwischen Public, Private, Community und Hybrid Cloud unterscheiden
  - Sie können die Servicemerkmale On-demand Self-Service, Broad network access, Rapid elasticity, Location independent resource pooling und measured service erläutern

- Sie können den Begriff des Serverless Computing, sowie dessen Vor- und Nachteile erläutern
  
  
  
  Serverless Computing bezieht sich auf eine Cloud-Computing-Architektur, bei der Entwickler Anwendungen erstellen und ausführen können, ohne sich um die Verwaltung der zugrunde liegenden Serverinfrastruktur kümmern zu müssen. Im Wesentlichen ermöglicht Serverless Computing Entwicklern, sich auf die Entwicklung von Code zu konzentrieren, während die Cloud-Provider die Skalierung, Bereitstellung und Verwaltung der zugrunde liegenden Serverinfrastruktur übernehmen.
  
  Vorteile von Serverless Computing:
  
  1. Skalierbarkeit: Die Plattform skaliert automatisch je nach Bedarf, wodurch Anwendungen auch unter stark schwankenden Lasten effizient ausgeführt werden können.
  2. Vereinfachte Infrastruktur: Entwickler müssen sich nicht um die Verwaltung von Servern, Betriebssystemen oder Middleware kümmern, was die Entwicklung und Bereitstellung beschleunigt.
  
  Nachteile:
  
  1. Einschränkungen bei Laufzeit und Umgebung: Serverless-Plattformen können Beschränkungen hinsichtlich der unterstützten Programmiersprachen, Laufzeitumgebungen und verfügbaren Bibliotheken aufweisen.
  
  2. Potenzielle Leistungsprobleme: Bei plötzlichen Lastspitzen kann es zu Einschränkungen oder Verzögerungen kommen, da Serverless-Plattformen bestimmte Einschränkungen für Ressourcen wie Speicher und Rechenzeit haben.
  
  

- Sie kennen die Grundlagen von EC2, S3 und Lambda-Funktionen bei AWS

    

1. EC2 (Elastic Compute Cloud): Ein Service, der skalierbare virtuelle Server in der Cloud bereitstellt, die als EC2-Instanzen bezeichnet werden und es Benutzern ermöglichen, Anwendungen auszuführen, die auf verschiedenen Betriebssystemen laufen.

2. S3 (Simple Storage Service): Ein skalierbarer Objektspeicherdienst, der es Benutzern ermöglicht, beliebige Daten in Form von Objekten zu speichern und abzurufen, wobei eine hohe Verfügbarkeit und Haltbarkeit gewährleistet ist.

3. Lambda-Funktionen: Ein serverloser Bereitstellungsservice, der es Entwicklern ermöglicht, Code auszuführen, ohne sich um die Verwaltung von Servern kümmern zu müssen. Lambda-Funktionen werden ereignisgesteuert ausgeführt und skalieren automatisch, basierend auf der eingehenden Last.

    

- Sie können die Grundlagen der Cloud-Ökonomie erläutern
  
  Die Cloud-Ökonomie bezieht sich auf die wirtschaftlichen Aspekte der Nutzung von Cloud-Computing-Diensten. Kernkonzepte umfassen:
  
  1. Pay-as-you-go: Nutzer zahlen nur für die tatsächlich genutzten Ressourcen, was eine flexible und skalierbare Kostenstruktur ermöglicht.
  
  2. Skalierbarkeit: Cloud-Dienste ermöglichen es Unternehmen, Ressourcen nach Bedarf zu skalieren, was Kostenoptimierung und Agilität unterstützt.
  
  3. OpEx statt CapEx: Cloud-Dienste ermöglichen es Unternehmen, operative Kosten (OpEx) anstelle von Kapitalausgaben (CapEx) zu haben, da Investitionen in die Infrastruktur vermieden werden können.
  
  4. Ressourcenoptimierung: Durch die effiziente Nutzung von Ressourcen und die Vermeidung von Überkapazitäten können Unternehmen Kosten senken und die Rentabilität verbessern.
  
  Insgesamt bietet die Cloud-Ökonomie Unternehmen die Möglichkeit, Kosten zu senken, die Geschäftskontinuität zu verbessern und Innovationen zu beschleunigen, indem sie den Zugang zu hochskalierbaren IT-Ressourcen zu wettbewerbsfähigen Preisen ermöglicht.
  
  

- Sie können die rechtlichen Aspekte der Datenverarbeitung im Zusammenhang mit der Cloud erläutern
  
  Man muss selbst für die Datensicherheit der Kunden sorgen. 
  
  

- Sie können Aspekte der Informationssicherheit im Zusammenhang mit der Cloud erläutern



1. Datenschutz und Compliance: Unternehmen müssen sicherstellen, dass ihre Daten in der Cloud angemessen geschützt sind und den geltenden Datenschutzbestimmungen und branchenspezifischen Compliance-Anforderungen entsprechen.

2. Zugriffskontrolle: Es ist entscheidend, den Zugriff auf Cloud-Ressourcen angemessen zu verwalten und zu kontrollieren, um unbefugte Nutzung oder Datenlecks zu verhindern. Dies umfasst die Implementierung von starken Authentifizierungsmethoden, Zugriffsbeschränkungen und die Überwachung von Benutzeraktivitäten.

3. Datenverschlüsselung: Sensible Daten sollten während der Übertragung und im Ruhezustand in der Cloud verschlüsselt werden, um deren Vertraulichkeit zu gewährleisten und sicherzustellen, dass sie selbst bei einem Sicherheitsvorfall nicht kompromittiert werden.

4. Netzwerksicherheit: Unternehmen sollten Sicherheitsmaßnahmen implementieren, um ihre Cloud-Netzwerke vor Bedrohungen wie DDoS-Angriffen (Distributed Denial of Service) oder Netzwerk-Sniffing zu schützen, um die Verfügbarkeit und Integrität ihrer Dienste zu gewährleisten.

5. Incident Response und Notfallwiederherstellung: Es ist wichtig, einen klaren Plan für die Reaktion auf Sicherheitsvorfälle zu haben und Mechanismen zur Wiederherstellung von Daten und Diensten im Falle eines Notfalls oder einer Datenpanne zu implementieren.

6. Sicherheitsüberwachung und Compliance-Berichterstattung: Unternehmen sollten fortlaufend ihre Cloud-Infrastruktur überwachen, Sicherheitsereignisse protokollieren und regelmäßige Sicherheitsprüfungen durchführen, um sicherzustellen, dass ihre Sicherheitsmaßnahmen wirksam sind und den Compliance-Anforderungen entsprechen.

Durch die Implementierung dieser Sicherheitsmaßnahmen können Unternehmen das Risiko von Sicherheitsvorfällen in der Cloud minimieren und das Vertrauen in die Sicherheit ihrer Daten und Anwendungen in der Cloud stärken.





##### PublicKey Auth. auf Linux:



[4. Public Key Authentifizierung](https://gbssg.gitlab.io/m346/virtual-key/)

```
sudo apt update
sudo apt install openssh-server
```

```
sudo service ssh status
```

```
sudo service ssh start
sudo ssh-keygen -A

```


