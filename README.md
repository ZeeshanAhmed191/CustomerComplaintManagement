# Customer Complaint Management System

A Dynamics 365 CRM project built using Microsoft Power Platform, Dataverse, JavaScript, and C# plugins to manage customer complaints and automate complaint resolution workflows.

## Project Overview

The Customer Complaint Management System helps customer service teams register complaints, track their status, prioritize critical issues, and manage the resolution process.

## Key Features

* **Customer Management:** Maintain customer records in Dataverse.
* **Complaint Tracking:** Create and manage complaints with priority, status, customer, and product details.
* **Business Rules:** Validate complaint information using JavaScript.
* **C# Plugin Automation:** Automatically set the complaint status to *In Progress* when its priority is *Critical*.
* **Business Process Flow:** Guide agents through complaint investigation, resolution, and closure.
* **Dashboards & Charts:** Visualize complaint totals, priorities, statuses, and product-related complaints.
* **Security Role:** Configure permissions for complaint agents.

## Technologies Used

* Microsoft Dynamics 365 / Power Apps
* Microsoft Dataverse
* Model-driven Apps
* JavaScript
* C# and .NET Framework
* Dynamics 365 SDK
* Power Platform CLI

## Solution Structure

* `src/` — Dataverse tables, forms, relationships, app configuration, web resources, and other solution components.
* `CustomerComplaintManagement.cdsproj` — Power Platform solution project file.
* `README.md` — Project documentation.

## Business Scenario

When a customer submits a critical complaint, the system automatically changes its status to *In Progress*. Agents can then follow the complaint resolution process, while dashboards help them monitor complaint activity.

## Project Purpose

This project demonstrates practical skills in Dynamics 365 CRM customization, Dataverse configuration, JavaScript form scripting, C# plugin development, business process automation, and solution management.

## Author

**Zeeshan Ahmed**

M.Sc. Mathematics | Aspiring Dynamics 365 CRM / Power Platform Developer

[GitHub Profile](https://github.com/ZeeshanAhmed191)
