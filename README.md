📌 EventEase App – Summary & Component Breakdown
📌 Overview
EventEase is a Blazor WebAssembly application for event management, allowing users to:
✅ Browse available events with details (name, date, location, description).
✅ Register for events with name and email.
✅ Track registered attendees for each event.
✅ Maintain user session state across pages.

📌 Key Components & Pages
1️⃣ EventCard.razor (Event Card Component)
📌 Displays event summary in a card format

Shows event name, date, and location.
Provides a button to navigate to event details or register.
🔹 Key Functionality:
✔ Used in event lists to show events dynamically.
✔ Clicking the event opens EventDetails.razor.
✔ Includes an “Add Event” function (admin use).

2️⃣ EventDetails.razor (Event Details Page)
📌 Shows full event details

Displays event name, date, location, and description.
Includes a "Register" button to navigate to Register.razor.
🔹 Key Functionality:
✔ Fetches event data from IEventService.
✔ Links to the event registration page.

3️⃣ Register.razor (Event Registration Page)
📌 Allows users to register for an event

Collects name and email using form validation.
Displays a list of registered attendees for the event.
Persists user session data using UserSessionService.
🔹 Key Functionality:
✔ Form validation (name & email required).
✔ Stores user session (pre-fills form if user has already registered).
✔ Tracks event participation (displays attendee list).

4️⃣ UserSessionService.cs (Session Management Service)
📌 Tracks logged-in user across pages

Saves user’s name and email after registration.
Pre-fills name and email in forms.
🔹 Key Functionality:
✔ Helps maintain state in a Blazor WebAssembly app.
✔ Prevents users from re-entering data on each visit.

5️⃣ AttendanceService.cs (Event Attendance Tracker)
📌 Manages event registrations

Stores a list of attendees per event.
Provides a method to fetch attendees for an event.
🔹 Key Functionality:
✔ Saves attendee details persistently.
✔ Allows the registration page to display attendees.

6️⃣ IEventService.cs & EventService.cs (Event Data Service)
📌 Handles event-related operations

Fetches event details for display.
Registers users for events.
Allows adding new events.
🔹 Key Functionality:
✔ Centralized data retrieval & CRUD operations for events.
✔ Works as a service layer to keep logic separate from UI.

📌 Application Flow
1️⃣ User visits the event list page → Sees events displayed using EventCard.razor.
2️⃣ User clicks an event → Navigates to EventDetails.razor.
3️⃣ User clicks “Register” → Navigates to Register.razor.
4️⃣ User enters name & email → UserSessionService saves session.
5️⃣ User gets added to AttendanceService → Name appears in attendee list.
6️⃣ User session persists → If they revisit, form is pre-filled.

📌 Summary
EventEase is a structured Blazor WASM app with:
✔ Component-based UI (EventCard, EventDetails, Register)
✔ State management (UserSessionService, AttendanceService)
✔ Form validation & dynamic attendee tracking
✔ Navigation between event details & registration

With this setup, future improvements can include:
➡ Database integration (replace in-memory storage with real DB).
➡ Admin features (event creation & management).
➡ Authentication (user logins & access control).

🚀 This architecture makes debugging and expanding the app easy!
