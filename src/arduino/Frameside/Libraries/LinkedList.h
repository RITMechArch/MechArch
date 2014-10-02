#include <iostream>
using namespace std;

typedef struct Node
{
    int number;
    Node* next;

    Node(int num)
    {
        number = num;
        next = NULL;
    }

} Node;

typedef struct LinkedList
{
    Node* head;
    int size;

    LinkedList()
    {
        head = NULL;
        size = 0;
    }
    
    void add(int num)
    {
        Node* newNode = new Node(num);
        Node* cur = head;
        if ( cur == NULL )
        {
            head = newNode;
        }
        else
        {
            if ( head->number > num )
            {
                newNode->next = head;
                head = newNode;
            }
            else
            {
                bool inserted = false;
                while ( cur->next != NULL )
                {
                    Node* next = cur->next;
                    if ( next->number < num )
                    {
                        cur = cur->next;
                    }
                    else
                    {
                        newNode->next = next;
                        cur->next = newNode;
                        inserted = true;
                        break;
                    }
                }
                // If the number wasn't inserted, insert at the end of the list.
                if ( !inserted )
                {
                    cur->next = newNode;
                }
            }
        }
        size++;
    }

    void print()
    {
        Node* cur = head;
        while (cur != NULL)
        {
            cout << cur->number << " ";
            cur = cur->next;
        }
        cout << endl;
    }

    int getSize()
    {
        return size;
    }
    
    void clear()
    {
        if ( head != NULL )
        {
            Node* cur = head;
            Node* nextNode;
            
            while ( cur->next != NULL )
            {
                nextNode = cur->next;
                delete cur;
                cur = nextNode;
            }
            delete cur;
            head = NULL;
        }
        size = 0;
    }
} LinkedList;
