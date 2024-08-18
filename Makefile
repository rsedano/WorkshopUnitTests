develop-branch: ## Create a new branch for development
	@if git rev-parse --verify develop >/dev/null 2>&1; then \
		if [ `git branch --show-current` != "develop" ]; then \
			git branch -d develop --force; \
			echo "Local branch 'develop' deleted."; \
		else \
			echo "Cannot delete 'develop' branch because you are currently on it."; \
		fi; \
	else \
		echo "Local branch 'develop' does not exist."; \
	fi
	@if git ls-remote --heads origin develop >/dev/null 2>&1; then \
		git push origin --delete develop; \
		echo "Remote branch 'develop' deleted."; \
	else \
		echo "Remote branch 'develop' does not exist."; \
	fi
	@if git ls-remote --heads origin main >/dev/null 2>&1; then \
		git switch -c develop origin/main; \
		git push origin -u develop; \
	else \
		echo "Remote 'origin/main' does not exist. Cannot create 'develop' branch."; \
	fi