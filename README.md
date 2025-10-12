

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

### ⚙️ Setup Instructions

#### 🖥️ Step 1: Clone the Repository
```bash
git clone https://github.com/<your-username>/OrbitEd-AR.git
cd OrbitEd-AR
