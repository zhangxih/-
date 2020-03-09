﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action <T> action)
        {
            Node<T> n = this.Head;
            while (n!=null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                list.Add(x);
            }
            list.ForEach(x => Console.WriteLine(x));
            int max = 0;
            int min = 999;
            list.ForEach(x => max = (x > max) ? x : max);
            list.ForEach(x => min = (x < min) ? x : min);
            Console.WriteLine(max);
            Console.WriteLine(min);
            int mum = 0;
            list.ForEach(x => mum += x);
            Console.WriteLine(mum);
        }

    }
}