

<h1 align="center">🌍 OrbitEd-AR</h1>
<h3 align="center">Inclusive AR-Based Aerospace, Space & Cybersecurity Education</h3>

<p align="center">
  <i>Empowering every learner through immersive, accessible, and multilingual AR education — even offline.</i>
</p>

---

<p align="center">
  <a href="#"><img src="https://img.shields.io/badge/Unity-2022.3%2B-black?style=flat-square&logo=unity"></a>
  <a href="#"><img src="https://img.shields.io/badge/AR-ARCore%20%7C%20ARKit-blue?style=flat-square&logo=google-ar"></a>
  <a href="#"><img src="https://img.shields.io/badge/AI-ONNX%20%7C%20LLMUnity-orange?style=flat-square&logo=python"></a>
  <a href="#"><img src="https://img.shields.io/badge/License-MIT-green?style=flat-square"></a>
  <a href="#"><img src="https://img.shields.io/badge/Platform-Android%20%7C%20iOS-lightgrey?style=flat-square&logo=apple"></a>
</p>

---

## 🚀 Overview

**OrbitEd-AR** is an **offline-first Unity3D app** that transforms aerospace and cybersecurity education through **interactive Augmented Reality (AR)**.  
Students can visualize **satellites, aircraft, and radar systems** in 3D, interact with them, and learn in **multiple Indian languages** with guidance from an **AI-powered tutor** — anywhere, anytime.

---

## 💡 Proposed Solution

| Challenge | Our Approach |
|------------|---------------|
| Lack of access to quality STEM education | Offline-first AR modules that run on mid-range Android/iOS devices |
| Language and accessibility barriers | Multilingual support, audio narration, subtitles, and gaze-based navigation |
| Low engagement in complex aerospace/cybersecurity topics | Immersive 3D AR + adaptive AI tutor to make learning fun and visual |

---

## 📊 Impact Metrics

| Metric | Description |
|---------|-------------|
| 🕓 **Learning Engagement** | Average time spent in AR-based learning sessions |
| 🧠 **Concept Retention** | Quiz score improvements and post-lesson recall |
| ♿ **Accessibility Usage** | Use of audio, subtitles, or gaze-control features |
| 🏫 **Adoption Rate** | Number of rural/underserved schools adopting OrbitEd-AR |

---

## 🧠 Tech Stack

| Component | Technology |
|------------|-------------|
| **AR & 3D Engine** | Unity3D, AR Foundation, ARCore/ARKit |
| **AI Tutor Engine** | LLMUnity / ONNX Runtime |
| **Localization** | Unity Localization Package |
| **Accessibility Tools** | PocketSphinx (Speech Recognition), eSpeak (Text-to-Speech), Gaze Control |
| **Target Devices** | Android & iOS (Offline-first) |

---

## 🌐 Scalability

- ✅ **Offline-first Design**: Works seamlessly in low-connectivity areas.  
- 🌏 **Modular AR Expansion**: Add future 3D modules (e.g., rocket engines, radar systems).  
- 🗣️ **Language Extensibility**: Plug in new regional languages easily.  
- 🤖 **AI Growth Potential**: Integrate improved on-device LLMs for smarter tutoring.  

---

## 🧩 Key Features

- 🛰️ **AR Visualization** – Explore aerospace and cybersecurity systems in 3D.  
- 💬 **AI-Powered Tutor** – Personalized learning experience based on student progress.  
- 🗣️ **Multilingual Support** – Learn in Hindi, Tamil, Bengali, and other Indian languages.  
- ♿ **Accessible Learning** – Voice, subtitles, and gaze-based controls for inclusivity.  
- 📶 **Offline Mode** – Learn anywhere without internet dependency.  

---

## 🏗️ System Architecture

The **OrbitEd-AR** system is designed around an **offline-first modular architecture** to ensure smooth performance, scalability, and accessibility — even in resource-limited environments.
┌──────────────────────────────┐
                    │         User Layer            │
                    │  • AR-based 3D Learning UI    │
                    │  • Gaze & Voice Interaction   │
                    │  • Multilingual Audio/Text    │
                    └─────────────┬────────────────┘
                                  │
                   ┌──────────────┴────────────────┐
                   │     Application Layer         │
                   │  • Unity3D AR Foundation SDK  │
                   │  • Scene & Object Management  │
                   │  • Offline Data Caching       │
                   └──────────────┬────────────────┘
                                  │
                   ┌──────────────┴────────────────┐
                   │        AI & Logic Layer        │
                   │  • LLMUnity / ONNX Runtime     │
                   │  • Adaptive Tutor Engine       │
                   │  • Knowledge Graph + NLP       │
                   └──────────────┬────────────────┘
                                  │
                   ┌──────────────┴────────────────┐
                   │    Localization & Accessibility│
                   │  • Unity Localization System   │
                   │  • PocketSphinx (Speech-to-Text)│
                   │  • eSpeak (Text-to-Speech)     │
                   │  • Gaze & Touch Controls       │
                   └──────────────┬────────────────┘
                                  │
                   ┌──────────────┴────────────────┐
                   │     Data & Storage Layer       │
                   │  • Local JSON/SQLite Storage   │
                   │  • Encrypted User Profiles     │
                   │  • AR Asset Bundles (Offline)  │
                   └────────────────────────────────┘

### 🔧 Architectural Highlights
- **Offline-First Engine**: All educational content and AI models are stored locally.  
- **Modular 3D Assets**: New AR modules can be added without modifying the main app.  
- **AI Tutor**: Uses lightweight on-device inference for adaptive question answering.  
- **Scalable Localization**: Easily extendable for new Indian languages and dialects.  

---

## 📱 How to Run the Mobile App

Follow these steps to build and test **OrbitEd-AR** on your Android or iOS device.

---

### 🧩 Prerequisites

- **Unity 2022.3 LTS or higher**  
- **Android Studio / Xcode** (depending on target platform)  
- **ARCore SDK (Android)** or **ARKit SDK (iOS)**  
- **ONNX Runtime for Unity**  
- **Minimum Device Requirements**:  
  - Android 10.0+ or iOS 13+  
  - 3GB RAM or higher  
  - Camera + Motion sensors enabled  

---

## 👨‍🚀 Team OrbitEd (Team EdOrbit)

| Role | Name |
|------|------|
| 🧭 **Team Lead** | **Debaditya Majumder** |
| 🧑‍💻 **Developer & Research** | **Arnab Mandal** |
| 🎨 **UI/UX & Documentation** | **Ankhi Bhattacharya** |

---

---

### ⚙️ Setup Instructions

Follow these steps to set up and run **OrbitEd-AR** seamlessly on your device.

---

#### 🖥️ Step 1: Clone the Repository

- Open **GitHub Desktop** or download the repository ZIP from the main page  
- Extract or open the project folder named **OrbitEd-AR**

---

#### 🧱 Step 2: Open in Unity

1. Launch **Unity Hub**  
2. Click **➕ Add Project → Select Folder** and choose the cloned folder  
3. Set the **Build Platform** to **Android** or **iOS**  
4. Install the following packages from the **Package Manager**:  
   - 🛰️ **AR Foundation**  
   - 📱 **ARCore XR Plugin** (Android) / **ARKit XR Plugin** (iOS)  
   - 🌐 **Localization Package**

---

#### 🚀 Step 3: Configure Build Settings

1. Go to **File → Build Settings**  
2. Select your target platform (**Android / iOS**)  
3. Click **Switch Platform**  
4. Add all necessary scenes to **Scenes in Build**  
5. Update **Company Name**, **Product Name**, and **Version** in *Project Settings → Player*

---

#### 📲 Step 4: Connect Device & Build

1. Enable **Developer Mode** on your mobile device  
2. Connect your device via **USB**  
3. In Unity, click **Build and Run**  
4. Wait for the build process to complete — the app will install automatically  

> ✅ Once launched, you’ll see the **AR onboarding screen**, ready for immersive learning!

---

🎯 **Tip:**  
For smoother AR performance, use **Release Mode** and reduce unused 3D assets during testing.

---

### 🖼️ Prototype Pics


<br><br> <!-- Adds vertical space for cleaner layout -->


![WhatsApp Image 2025-10-11 at 17 36 05_9482ac36](https://github.com/user-attachments/assets/bc129bb5-b87f-4236-a2f7-0c5f0922d461)

![WhatsApp Image 2025-10-11 at 17 36 57_aa3ecd36](https://github.com/user-attachments/assets/f85e7719-5a22-4058-8d89-eacdead5bc4a)

![WhatsApp Image 2025-10-13 at 00 11 52_ceceb179](https://github.com/user-attachments/assets/e4a799f3-6a17-47b9-814e-8185365e0e25)

![WhatsApp Image 2025-10-13 at 00 12 00_1b063f4f](https://github.com/user-attachments/assets/efbae163-aeba-40aa-ac68-68a9ece29ffe)

<br><br> <!-- Adds more breathing room after the image gallery -->

---


## 🪐 Team EdOrbit Vision

> “To make aerospace and cybersecurity education accessible, inclusive, and exciting for every learner through immersive **Augmented Reality** and intelligent **on-device AI**.”

---

## 💬 Contact

| Type | Details |
|------|----------|
| 📧 **Email** | arnabmandal261@gmail.com |
| 🌐 **GitHub** | [github.com/Team-EdOrbit](https://github.com/Team-EdOrbit) |
| 🛰️ **Project Repository** | [OrbitEd-AR](https://github.com/Arnab-apk/Gentech_Thales_Prototype) |

---

✨ *Team EdOrbit — Inspiring the next generation of aerospace and cybersecurity innovators through AR and AI.*  

