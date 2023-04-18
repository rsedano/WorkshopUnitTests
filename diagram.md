graph LR
    subgraph "GitHub Repositories"
        CheckIn_Code --> Repo
        CheckOut_Code <--> Repo
        Repo <--> CheckOut_Code2
    end
    subgraph "GitHub Action Build Images"
    CheckOut_Code2 --> Build_Image
    Build_Image --> Push_Image
    Push_Image --> Snyk_Scan
    Snyk_Scan --> Kosli_Report
    Kosli_Report --> Deploy_Environment
    end
    subgraph "Deployed Environment"
        Deploy_Environment
    end
