# Database Schema Specifications

- **Users**: UserId (PK), RoleId (FK), FirstName, LastName, Email, PasswordHash
- **Roles**: RoleId (PK), RoleName
- **Events**: EventId (PK), OrganisationId (FK), EventName, Date, Location
- **EventEnrolments**: EnrolmentId (PK), ParticipantId (FK), CategoryId (FK)
