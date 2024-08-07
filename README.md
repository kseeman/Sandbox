## Welcome to the Sandbox repository

This repository is a sandbox for testing and learning purposes.

### How to contribute

1. **Fork the repository**: Click the "Fork" button at the top right of the repository page to create your own copy of the repository.
2. **Clone your fork**: Clone your forked repository to your local machine using `git clone <your-forked-repo-url>`.
3. **Create a new branch**: Create a new branch for your changes using `git checkout -b <branch-name>`.
4. **Make your changes**: Add your content or make changes in your branch.
5. **Push your changes**: Push your changes to your forked repository using `git push origin <branch-name>`.

### How to keep your fork up-to-date

1. **Add the original repository as a remote**: This step is only needed once.
    ```sh
    git remote add upstream <original-repo-url>
    ```

2. **Fetch the latest changes from the original repository**:
    ```sh
    git fetch upstream
    ```

3. **Merge the changes into your local branch**:
    ```sh
    git checkout main
    git merge upstream/main
    ```

4. **Push the updated branch to your fork**:
    ```sh
    git push origin main
    ```