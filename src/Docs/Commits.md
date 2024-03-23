# Commit message conventions

To maintain a clear and consistent project history we follow a simplified convention for our commit messages. This helps in quickly understanding the purpose of each change and assists in automated changelog generation.

## Types of commits

### Feature

- **Purpose:** Introduce new features or significant enhancements.
- **Prefix:** `feature:`
- **Example:** `feature: implement jwt authentication, feature: add product service`

### Fix

- **Purpose:** Fix issues or bugs in the software.
- **Prefix:** `fix:`
- **Example:** `fix: login error via local strategy, fix: incorrect validations for products`

### Update

- **Purpose:** Implement minor changes or improvements that don't add new features or fix bugs. This includes small enhancements, dependency updates or other miscellaneous changes.
- **Prefix:** `update:`
- **Example:** `update: improve product validation logic, update: upgrade .NET 7 to .NET 8`

### Refactoring

- **Purpose:** Reorganize or improve existing code without changing its external behavior. This is typically used for code clean-up simplifying structures or improving readability without affecting functionality.
- **Prefix:** `refactoring:`
- **Example:** `refactoring: remove unused usings, refactoring: rename ambiguous variables in auth service`

## Writing commit messages

- Start with the appropriate prefix (`feature:`, `fix:`, `update:`, `refactoring:`) to clearly indicate the type of change.
- Write the message in the imperative mood as if giving a command: "add", "fix", "improve", etc.
- Keep the message concise but descriptive enough to understand the context and purpose of the change without needing to look at the code changes.
- Write messages in lower case for consistency