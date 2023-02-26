using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool isWord = false;
        public bool Contains(char c) => children.ContainsKey(c);
        public bool isLeaf() => children.Count == 0;
        public void AddChield(char c) => children[c] = new TrieNode();
        public TrieNode getNext(char c) => children[c];
        public List<TrieNode> childrensNodes() => (from x in children select x.Value).ToList();
        public void printDict()
        {
            Console.WriteLine("childs");
            foreach (var pair in children)
            {
                Console.Write($"{pair.Key} : ");
                foreach (char c in pair.Value.children.Keys) Console.Write($" {c} ");
                Console.WriteLine();
            }
        }
    }
    public class Trie
    {
        TrieNode root;
        public Trie() => root = new TrieNode();

        public void InsertRange(IEnumerable range)
        {
            foreach (string word in range)
                this.Insert(word);
        }
        public void Insert(string word)
        {
            TrieNode temp = root;
            foreach (char c in word)
            {
                if (!temp.Contains(c)) temp.AddChield(c);
                temp = temp.getNext(c);
            }
            temp.isWord = true;
        }
        public bool CanBeFormed(TrieNode node,string s,int index)
        {
            if (index == s.Length)
            {
                return node.isWord;
            }
            char c = s[index];
            if (!node.Contains(c)) return false;
            TrieNode next = node.getNext(c);
            if (node.isWord)
                return CanBeFormed(root,s, index + 1) || CanBeFormed(next,s,index+1);
            return CanBeFormed(next, s, index + 1);
        }
    }
}
