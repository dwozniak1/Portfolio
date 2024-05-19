﻿//Name: Delaney Wozniak
//Class:INFO 2200
//Section: X01
//Professor: Sharp
//Date: 2/19/2024
//Project #: Participation 3
//By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. 
//I attest that no part of this assignment, in whole or in part, was generated by Generative Artificial Intelligence (e.g., ChatGPT, Bard, Copilot, etc.) nor obtained from a paid solution service (e.g., Chegg, Course Hero, Bartleby, etc.). 
//I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_WozniakD_Participation03
{
    /// <summary>
    ///  created class named Tree derived from Plant class
    /// </summary>
    public class Tree : Plant
    {
        // created constructor method and passed it onto the base class, also made it readable and writeable
        public Tree(string env, string typ, string nm) : base(env, typ, nm)
        {

        }
        // created Sniff method
        public override string Sniff() // override Sniff variable in Plant class
        {
            return "I like the smell of trees."; //displays message
        }
    }
}
