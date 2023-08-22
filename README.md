# 1. Car Management Booking System
The "Car Management Booking System" is a comprehensive web application developed using the WinForms ASP .NET SDK 5.0.408 framework. The objective of the Car Booking Management Project is to optimize the procedure of reserving and overseeing car rentals with efficiency. The system encompasses four distinct roles: Guest, Member, Staff, and Admin, all contributing to a fluid and user-friendly interface.

## 1.1 Product Perspective
- For guests, the platform provides the chance to explore accessible vehicles and their particulars without necessitating registration. Should they decide to move forward with a booking, guests have the option to register as members, thereby unlocking added privileges and perks.

- The Member role affords registered users an upgraded experience. Members can seamlessly peruse the range of available cars, view their specifications, and conveniently make reservations. Moreover, members enjoy the benefit of accessing their booking history, simplifying future reservation processes. The shift from guest to member is facilitated through successful registration, granting users exclusive entry to membership advantages.

- The Staff role is tailored to assist both guests and members. Staff members are entrusted with the task of managing and updating the car inventory, ensuring accuracy in vehicle particulars, availability, and pricing information. Additionally, they are on hand to address user inquiries, concerns, or alterations to bookings, contributing to elevated customer satisfaction levels.

- The Admin role commands the highest level of authority and responsibility. Admins oversee the overall functionality of the system, oversee staff accounts, and possess the authorization to review and authorize membership registrations. They are also equipped with the tools required to manage system-wide settings, thereby ensuring the system's smooth and secure operation.

- The Car Booking Management Project furnishes an inclusive solution that accommodates a diverse user spectrum, spanning from casual guests to devoted members, and from diligent staff to commanding administrators. Through meticulous administration and execution of each role's duties, the project's aim is to streamline the car rental process, elevate user experiences, and establish an effective and user-centric car booking environment.


## 1.2	User Classes and Characteristics
The Car Booking Management System consists of four main user classes: Guest, Member, Staff, Admin.
### Guest
-	Guests are individuals seeking to rent cars. They use the system to search available vehicles, make reservations based on their start and end date.
-	Guests can find the cars with the price they provided. They can view the information about the car, and able to add it into the cart
### Member
-	To become a member of the system, the guest must register an account into the system
-	Members can checkout the booking, and they can see the purchase history of a booking that they had made.
### Staff
-	The system will have different staff members to manage the cars in the system
-	They can view a list of cars rented by members
-	They can track the availability of cars based on the bookings
### Admin: A system will have one admin to manage all the staff and members in the system.
In the system, there are some specific rules for members to make a car reservation
-	Members can book various cars, but at the same time, they can only book a specific car.
-	A booking can have many cars, but the booking and expired date will need to be different. This allows another member can book a car
-	If a member has made a reservation, they can still change the booking and expiration date before checkout the booking.

# 2. Database Design
## Conceptual Diagram
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/b4916737-5eb4-44ad-9a3d-7f7ffed756be)

## Logical Diagram
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/644c4bdc-52b7-415a-9590-e12503cb459d)

## Database Diagram
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/3147bc1f-acca-45e2-ab55-df972f8f7ee9)


# 3. System Architecture 
The car booking management system follows a 3-layer architecture that ensures efficient data flow, separation of entities and business logic, and is easy to maintain. The technologies are used in this project including .NET 5, Entity Framework Core (version 5), and Microsoft SQL Server. The architecture delivers a robust and user-friendly interface to different actors, comprising guests, members, staff and admins.
-	Presentation Layer: It is implemented through Winforms, is the user interface where users interact with the system. It will provide an intuitive and user-friendly environment for managing bookings, car reservations, and accessing various system features. 
-	Business Logic Layer: Serving as the core of the application, the business logic layer is responsible for implementing business rules, orchestrating data processing, and managing system behavior. It receives user requ
ests from the presentation layer and determines the appropriate actions to take.
-	Data Access Layer (Repository and Data Access Objects): It is responsible for data retrieval and storage. It is divided into 2 sub-layers: the Repository and Data Access Object layer.
-	Repository: This layer provides the interface for interacting with the data. It abstracts the underlying data storage and exposes methods to access and manipulate entities. It ensures a consistent and standardized way to perform CRUD (Create, Read, Update, Delete) operations on data entities.
-	Data Access Object: The DAO layer encapsulates the lower-level data access operations. It communicates directly with the database through technologies like Entity Framework Core 5 and MS SQL Server. It's responsible for executing database queries, managing data integrity, and ensuring efficient data retrieval and storage.

# 4. Implementation
Efficiently deploying the Car Booking Management Project entails a strategic approach to transition from development to operational implementation. The process involves a series of tasks geared toward ensuring the application's stability, performance, and accessibility.

## User Access and Considerations:
For users, including guests, members, staff, and administrators, seamless access to the Car Booking System is essential. User distribution across different time zones necessitates careful planning to provide uninterrupted service. Infrastructure adjustments may be required to optimize network accessibility and accommodate anticipated user demand. Minimizing latency is pivotal for a smooth user experience.

## Infrastructure Adaptations and Capacity Strategy:
Deployment may entail necessary infrastructure modifications to meet capacity needs. Rigorous evaluation of network infrastructure ensures data transfer efficiency and reliability. Adequate data storage planning is essential to accommodate future data growth, encompassing reservations and booking history. Data migration strategies should be in place for seamless data transition. Should the application's load necessitate additional servers or cloud resources, deployment should encompass these adjustments.

## Training and Business Process Enhancement:
Successful deployment hinges on comprehensive training resources for both users and staff. Clear guidelines detailing Car Booking System usage, reservation processes, and member privileges are paramount. Effective communication about potential business process changes, particularly those related to car rental and management, is crucial. Staff responsibilities might require refinement to align with the new system's capabilities.

In conclusion, deploying the Car Booking Management Project necessitates meticulous planning and execution for a seamless shift to operational use. User access must cater to distribution and time zone variations. Infrastructure adaptations should optimize network performance and data storage. Thorough training materials and business process integration will facilitate user adoption and align operational workflows with the new system's features. Addressing these aspects will ensure a successful deployment that elevates car booking and management processes.

# Screenshot
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/512d32eb-9fee-450e-8293-a1f9d1b46fa1)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/061c7f40-ce4a-4bb0-a25d-d013eb8ee542)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/ab0627e2-10fe-434e-9a55-acbfcbad37f3)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/6cb6fd38-660c-4499-bfac-f58f1d6286dd)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/70edae9f-d859-49d0-b624-d8636761b07c)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/c7ac30dd-2fa2-4ef7-8c4d-4191c89933a6)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/a3bf4cd1-dede-4e10-9346-080ecb6914c0)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/8a30e247-b026-48ff-bfb4-5a7ece18cd69)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/63b606e2-9fc1-4dd8-bac8-7a187083a425)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/2f552312-2958-453d-9927-63650e444162)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/456f80f8-083c-429c-81c1-4ca7b93eba2a)
![image](https://github.com/UyLeQuoc/Car-Management-Booking-System/assets/91858657/aa0bf149-2d3c-4d00-9619-8aec0c1195a1)

# Starting the project
- `git clone "this repo"`
- Run SQL script in `CarBookingManagement.sql`
- Open Solution In Visual Studio 2019/2022: `GroupProject_PRN211_3W_CarManagementBookingSystem.sln`
- `dotnet run`

# Contact
## Member:
- Nguyễn Tiến Dũng - nguyentiendung2003@gmail.com - [Github](https://github.com/NTDung93)
- Nguyễn Đức Sơn -  - [Github](https://github.com/Son-2003)
- Vũ Long - nguyenducson2915@gmail.com - [Github](https://github.com/longvu2211)
- Lê Quốc Uy - lequocuyit@gmail.com - [Github](mailto:lequocuyit@gmai.com)
  
## Bug report or Feature request

If you encounter a bug or have a feature request, [send us an email](mailto:lequocuyit@gmai.com), [create an issue](https://github.com/UyLeQuoc/dsc-force-graph/issues).

## License

The MIT License.

<p align="right"><a href="#top">⬆️ Back to top️</a></p>
