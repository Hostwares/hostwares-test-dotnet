# Hostwares Test - .NET 8

A minimal .NET 8 Web API for testing deployment on Hostwares.

## Environment Variables

| Variable | Description | Required |
|----------|-------------|----------|
| APP_NAME | Display name | No |
| ASPNETCORE_ENVIRONMENT | Runtime env | No |
| CONNECTION_STRING | SQL Server/PostgreSQL connection | No |
| API_SECRET | Secret key for API auth | No |

## Endpoints

- `GET /` — App info + env var status
- `GET /health` — Health check

## Deploy on Hostwares

1. Create a new site → select this repo
2. Set environment variables
3. Deploy! (uses .NET 8 SDK multi-stage Docker build)
