# NutriBite 
**A Cross-Platform Nutritional Tracker and Meal Logger**

##  Author Information
* **Author Name:Li Wenhui
* **Student ID:21906402
* **Module:** 6G6Z0014 - Mobile Computing
* **Assessment:** 1CWK100 - Developing a Cross-Platform Mobile App

##  App Overview
NutriBite is a premium, cross-platform mobile application developed using **C# and .NET MAUI**. Built strictly around the "Food and Drink" theme, it serves as a smart nutritional tracker that allows users to log their daily meals, view detailed macronutrient breakdowns (Calories, Protein, Carbs, Fat), and manage dietary restrictions (allergy notes).

The application strictly adheres to the **MVVM (Model-View-ViewModel)** architectural pattern and features a highly consistent, custom-built "Modern Culinary" design system. It seamlessly supports both **Android** and **Windows** desktop environments from a single codebase.

##  Development Plan & Implemented Features
To ensure a high-quality product, the development plan focused on delivering robust features across UI/UX, Hardware integration, and API management:

### 1. UI/UX Design & Accessibility
* **Custom Styling:** Extensive use of XAML Resource Dictionaries to create a consistent "Modern Culinary" aesthetic.
* **Dynamic Theming:** Full support for system-level **Light and Dark mode** transitions.
* **Micro-interactions:** Integrated `VisualStateManager` for smooth button scaling animations.
* **Accessibility:** Adheres to accessibility standards. UI uses relative layouts to support dynamic system font scaling. High-contrast colors are maintained in both themes.

### 2. Native Hardware Integration
NutriBite deeply integrates with multiple mobile hardware features:
* **Camera (MediaPicker):** Captures real-time photos of meals.
* **Location & Geocoding:** Fetches device coordinates and reverse-engineers them into human-readable locations where the meal was logged.
* **Haptic Feedback:** Provides tactile vibration responses during critical user actions (e.g., saving data).
* **Text-to-Speech (TTS):** Audibly reads out the complete nutritional summary and allergy warnings for visually impaired users.

### 3. Advanced Validation & Error Handling
* **Input Validation:** Prevents form submission if required fields are empty or if numerical fields (e.g., calories) contain invalid/negative values.
* **Offline Fault Tolerance:** The app communicates with a cloud RESTful API (`mockapi.io`). If the network connection drops (e.g., Airplane mode), the service layer catches the `HttpRequestException` and gracefully falls back to a local offline dataset without crashing.

##  How to Run the App (Important Setup)

If you intend to compile and run this application, please ensure the following environment setups:

### 1. Cloud Database (MockAPI) Configuration
The app relies on `mockapi.io` for cloud storage. Before running, you must configure the endpoint:
1. Open `Services/MockApiConfig.cs`.
2. Insert your specific MockAPI endpoint URL into the `EndpointUrl` constant string. 
*(Note: If no URL is provided, the app will safely fallback to local hardcoded data without crashing).*

### 2. Android Emulator Hardware Setup
To properly test the hardware features on an Android Emulator:
* **Location:** Open the emulator's *Extended Controls (...) -> Location*, search for a city, and click **"Set Location"**. Otherwise, the Geolocation API may timeout waiting for initial GPS data.
* **Camera:** The default emulator camera will display a virtual 3D room. Simply press the capture button and then the checkmark (✓) to confirm the hardware call.
* **Audio:** Ensure the emulator's media volume is turned up to hear the Text-to-Speech functionality.

### 3. Deployment
* **Android:** Tested on Android API 31+.
* **Windows (Desktop):** The app is configured with specific window dimensions in `App.xaml.cs` to ensure it acts as a premium desktop widget. If updating the Windows build, ensure any previously cached versions of the app are uninstalled from the Windows Start Menu before rebuilding.