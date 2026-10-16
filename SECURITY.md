# Security Policy

## Password Security
- All user passwords are salt-hashed using BCrypt.Net-Next before database persistence.

## Session Management
- HttpOnly cookies are used for session tracking to reduce XSS risks.
