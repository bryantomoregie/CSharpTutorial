using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class Post
    {
        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            DateTime = DateTime.Now;
        }


        private string _title;

        public string Title
        {
            get { return _title; }
            
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime DateTime { get; set; }
        
        private int vote = 0;

        public int Vote
        {
            get { return vote ; }
        }


        public void UpVote()
        {
            vote++;
        }

        public void DownVote()
        {
            vote--;
        }

        public void EditTitle()
        {
            Console.WriteLine(Title);
            Console.WriteLine("Edit title and press enter");
            _title = Console.ReadLine();
        }

        public void EditTitle(string title)
        {

            _title = title;
        }

        public void EditDescription()
        {
            Console.WriteLine(Description);
            Console.WriteLine("Edit Description and press enter");
            _description = Console.ReadLine();
        } 
        
        public void EditDescription(string description)
        {
            _description = description;
        }
    }
}

/*
Exercise 2: Design a StackOverflow Post Design a class called Post. 
This class models a StackOverflow post. It should have properties for title, 
description and the date/time it was created. We should be able to up-vote or 
down-vote a post. We should also be able to see the current vote value. In the 
main method, create a post, up-vote and down-vote it a few times and then display 
the the current vote value. In this exercise, you will learn that a StackOverflow post
should provide methods for up-voting and down-voting. You should not give the 
ability to set the Vote property from the outside, because otherwise, you may 
accidentally change the votes of a class to 0 or to a random number. And this
is how we create bugs in our programs. The class should always protect its 
state and hide its implementation detail. 

properties for title, description, date/time, votes
Methods to upvote, downvote, see how many votes, 

 */
