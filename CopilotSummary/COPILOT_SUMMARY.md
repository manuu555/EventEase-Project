# Copilot Summary – EventEaseApp

## 1. Event Card component
I used Microsoft Copilot to help generate the initial Event Card component.  
Copilot suggested the C# properties for the event details (`EventTitle`, `EventDate`, `Location`, `Description`) and the Razor markup with `@bind` so the inputs use two-way data binding. I asked Copilot to adjust the layout so the Event Card shows a live preview section.

## 2. Routing and navigation
When I added new pages, Copilot helped me configure routing.  
It suggested using the `<Router>` component in `App.razor` and gave examples of `@page` routes like `/event-card`, `/register`, and `/attendance`. I also used Copilot suggestions to fix “Not Found” and routing errors until each URL opened the correct page.

## 3. Debugging and optimization
During the project I had many build and runtime errors (namespace issues, missing services, and routing problems).  
Copilot helped me understand error messages, add the correct `using` statements, and simplify the code in `Program.cs`, `_Imports.razor`, and my Razor pages. This made the project easier to maintain and reduced runtime errors.

## 4. Registration form with validation
Copilot helped create the registration form model with data annotations like `[Required]` and `[EmailAddress]`.  
It suggested using `<EditForm>`, `<InputText>`, `<DataAnnotationsValidator>`, and `<ValidationSummary>`. I used these suggestions to make sure invalid input is blocked and a success message is shown after a valid registration.

## 5. State management and Attendance tracker
I asked Copilot for a way to share data between pages.  
It helped me create the `EventStateService` class with an `Attendees` list and an `AddAttendee` method, and then register it with `builder.Services.AddScoped<EventStateService>()` in `Program.cs`.  
Copilot also assisted in using this service in `RegistrationForm.razor` and `AttendanceTracker.razor` so that new registrations appear in the attendance table.

## 6. Final integration and UI improvements
At the end, Copilot helped me polish the UI.  
It suggested button styles and layout ideas for the EventEase home page, with links to Event Card, Register, and Attendance. This made the app feel like a complete, user-friendly project that matches the assignment requirements.
