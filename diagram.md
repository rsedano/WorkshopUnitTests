+-----------------+          +-------------------------+
| GitHub          |          | Container Registry       |
| Repositories    |          | (Docker Hub, AWS ECR,    |
|                 |          |  Google Container Reg,   |
|                 |          |  etc.)                   |
+-----------------+          +-------------------------+
        |                            |
        |                            |
        v                            v
+-----------------+          +-------------------------+
| Checkout Code   |          | Push Image to Registry   |
|                 |          | (using Docker Build)     |
+-----------------+          +-------------------------+
        |                            |
        |                            |
        v                            v
+-----------------+          +-------------------------+
| Build Image     |          | Snyk and Kosli Scans      |
| (using Dockerfile)|         | (or other security scans)|
+-----------------+          +-------------------------+
        |                            |
        |                            |
        v                            v
+-----------------+          +-------------------------+
| Deploy to       |          | Deployed Environment     |
| Environment     |          | (Test, Prod, etc.)       |
+-----------------+          +-------------------------+
