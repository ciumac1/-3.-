# Git Repository
## What is Git?
So, what is Git in a nutshell? This is an important section to absorb, because if you understand what Git is and the fundamentals of how it works, then using Git effectively will probably be much easier for you. As you learn Git, try to clear your mind of the things you may know about other VCSs, such as CVS, Subversion or Perforce — doing so will help you avoid subtle confusion when using the tool. Even though Git’s user interface is fairly similar to these other VCSs, Git stores and thinks about information in a very different way, and understanding these differences will help you avoid becoming confused while using it.

## Getting a Git Repository
ou typically obtain a Git repository in one of two ways:

1. You can take a local directory that is currently not under version control, and turn it into a Git repository, or

2. You can clone an existing Git repository from elsewhere.

In either case, you end up with a Git repository on your local machine, ready for work.

## Initializing a Repository in an Existing Directory
If you have a project directory that is currently not under version control and you want to start controlling it with *Git*, you first need to go to that project’s directory. If you’ve never done this, it looks a little different depending on which system you’re running:
* for Linux:
$ cd /home/user/my_project

* for macOS:
$ cd /Users/user/my_project

* for Windows:
$ cd C:/Users/user/my_project

and type:
$ git init

This creates a new subdirectory named .git that contains all of your necessary repository files — a Git repository skeleton. At this point, nothing in your project is tracked yet. See Git Internals for more information about exactly what files are contained in the               *.git* directory you just created.

## Git add 
The git add command adds a change in the working directory to the staging area. It tells Git that you want to include updates to a particular file in the next commit. However, git add doesn't really affect the repository in any significant way—changes are not actually recorded until you run **git commit**.


## Git commit
What is a **Git commit**? In Git, a commit is a snapshot of your repo at a specific point in time. To help further understand what a Git commit is, we need to review your Working Directory vs your Staging Directory and how files changes are reflected in your Git repository.

## Git status 
The **git status** command displays the state of the working directory and the staging area. It lets you see which changes have been staged, which haven't, and which files aren't being tracked by *Git*.

## Basic writing and formatting syntax
Create sophisticated formatting for your prose and code on GitHub with simple syntax
Headings
To create a heading, add one to six # symbols before your heading text. The number of # you use will determine the size of the heading.

**examples**:

 # The largest heading

 ## The second largest heading

 ###### The smallest heading

![стили](Style.png)
#   - 1 . -  
 