### 📱 Projekt: "Shiftly – System Zarządzania Grafikami Pracy"



#### 🎯 Cel: Mobilna aplikacja dla pracowników i menedżerów umożliwiająca zarządzanie grafikami zmianowymi, urlopami oraz komunikacją zespołu

---

## 🔧 Zakres funkcjonalny aplikacji:

### Dla pracownika:

* Przegląd własnego grafiku (kalendarz zmian)
* Wysyłanie wniosków o urlop (CRUD)
* Odbieranie powiadomień o zmianach w grafiku (event-driven)
* Prośby o zamianę zmian z innymi pracownikami

### Dla menedżera:

* Zarządzanie zmianami pracowników (CRUD)
* Akceptowanie/odrzucanie wniosków urlopowych
* Generowanie grafiku i eksport do PDF
* Powiadomienia o brakach kadrowych

---

## 📐 Zadania projektowe (zgodnie z kryteriami)

### ✅ Zadanie 1 (obsługa zdarzeń / wielowątkowość):

**Rozwiązanie: Event-driven notifications using Azure Service Bus**

* Gdy menedżer zatwierdzi urlop, event trafia do kolejki Service Bus → pracownik otrzymuje notyfikację

### ✅ Zadanie 2 (wzorzec projektowy):

**Rozwiązanie: Factory Pattern + Extension Methods**

* Factory do tworzenia różnych typów użytkowników (Pracownik, Menedżer)
* Extension method do formatowania godzin zmian dla kalendarza
* Możliwe użycie refleksji w backendzie .NET ]

---

## ☁️ Usługi Azure:

| Usługa                  | Zastosowanie                                     | Punkty   |
| ----------------------- | ------------------------------------------------ | -------- |
| Azure SQL/MongoDB       | Przechowywanie danych pracowników, grafików      | –        |
| **Azure Service Bus**   | Obsługa zdarzeń – system notyfikacji             | **+1**   |
| **Azure Blob Storage**  | Przechowywanie dokumentów PDF (grafik, urlopy)   | **+0.5** |
| **Azure Queue Storage** | Alternatywa dla Service Bus, kolejka prostsza    | +0.5     |
| **Azure CDN**           | Przyspieszenie ładowania zasobów (np. grafik UI) | +0.5     |
| **Redis Cache**         | Przechowywanie tymczasowych danych grafików      | +1       |
| **Autoscaling App**     | Automatyczne skalowanie frontendu                | +0.5     |
| **VM (opcjonalnie)**    | Wydzielone API, np. dla raportów PDF             | +1       |
| **File Storage**        | Przechowywanie szablonów zmian, obrazów profilu  | +0.5     |

---

## 💻 Technologia:

* **Frontend (Mobile)**: React Native (Expo)
* **UI/UX**: UxPin (prototyp interfejsu)
* **Backend**: .NET (dla wzorców + refleksji)
* **Baza danych**: Azure Cosmos DB (MongoDB API) 

---

## 📲 Użyteczność i skala odbiorców:

* Praktyczna aplikacja dla firm i zespołów z pracą zmianową (gastronomia, retail, logistyka)
* Może być wykorzystywana przez tysiące małych i średnich firm

---

## 📈 Prototyp UX:

* Przygotowany w UxPin (min. 5 głównych ekranów)

  * Dashboard
  * Mój grafik
  * Zarządzanie wnioskami
  * Wysyłanie prośby o zamianę
  * Notyfikacje i komunikaty

---

## 📌 Dodatkowe punkty:

* Responsywny design
* Możliwość częściowej implementacji (pełny frontend + część logiki backendowej i integracji z Azure)

---

## 🔁 Lista Endpointów REST API:

### 👤 Autentykacja

* `POST /auth/register` – rejestracja użytkownika
* `POST /auth/login` – logowanie
* `GET /auth/profile` – dane zalogowanego użytkownika

### 👥 Użytkownicy

* `GET /users` – lista użytkowników (tylko dla menedżera)
* `GET /users/:id` – szczegóły użytkownika
* `POST /users` – tworzenie użytkownika
* `PUT /users/:id` – aktualizacja danych użytkownika
* `DELETE /users/:id` – usunięcie użytkownika

### 🕒 Zmiany

* `GET /shifts` – lista zmian (dla użytkownika zalogowanego)
* `GET /shifts/:id` – szczegóły zmiany
* `POST /shifts` – tworzenie nowej zmiany (menedżer)
* `PUT /shifts/:id` – edycja zmiany
* `DELETE /shifts/:id` – usunięcie zmiany

### 🌴 Urlopy

* `GET /leave-requests` – lista wniosków urlopowych
* `POST /leave-requests` – nowy wniosek urlopowy
* `PUT /leave-requests/:id/approve` – zatwierdzenie przez menedżera
* `PUT /leave-requests/:id/reject` – odrzucenie

### 🔄 Prośby o zamianę zmian

* `GET /swap-requests` – lista próśb o zamianę
* `POST /swap-requests` – nowa prośba
* `PUT /swap-requests/:id/approve` – zatwierdzenie
* `PUT /swap-requests/:id/reject` – odrzucenie

### 🔔 Notyfikacje

* `GET /notifications` – lista powiadomień
* `POST /notifications` – dodanie powiadomienia (automatycznie przez system)

### 📁 Pliki i eksporty

* `GET /shifts/export/pdf` – eksport grafiku do PDF (Blob Storage)
* `POST /uploads/avatar` – upload zdjęcia użytkownika (File Storage)
