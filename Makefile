develop-branch: ## Create a new branch for development
	@if git rev-parse --verify develop >/dev/null 2>&1; then \
		if [ `git branch --show-current` != "develop" ]; then \
			git branch -d develop --force; \
			echo "Local branch 'develop' deleted."; \
		else \
			echo "Cannot delete 'develop' branch because you are currently on it."; \
			echo "Switching to 'main' branch..."; \
			git switch main; \
			git branch -d develop --force; \
			echo "Local branch 'develop' deleted."; \
		fi; \
	else \
		echo "Local branch 'develop' does not exist."; \
		echo "Switching to 'main' branch..."; \
		git switch main; \		
	fi
	@if git ls-remote --heads origin develop >/dev/null 2>&1; then \
		echo "Deleting remote branch 'develop'..."; \
		git push origin --delete develop; \
		echo "Remote branch 'develop' deleted."; \
	else \
		echo "Remote branch 'develop' does not exist."; \
	fi
	@if git ls-remote --heads origin main >/dev/null 2>&1; then \
		echo "Creating 'develop' branch from main..."; \
		git switch -c develop origin/main; \
		git push origin -u develop; \
		echo "Branch 'develop' created and pushed to remote."; \
		echo "Notifiy to your collegues in Slack channel #team-cf."; \
		echo "They should delete their develop brahcn and fetch the new one."; \
	else \
		echo "Remote 'origin/main' does not exist. Cannot create 'develop' branch."; \
	fi