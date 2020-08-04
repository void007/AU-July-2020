import java.util.LinkedList;
import java.util.Queue;
import java.util.concurrent.locks.Condition;
import java.util.concurrent.locks.*;
import java.util.concurrent.locks.ReentrantLock;

public class BlockingQueueNew {
    private Queue<Integer> queue = new LinkedList<>();
    private int capacity;
    private Lock lock = new ReentrantLock();
    private Condition notFull = lock.newCondition();
    private Condition notEmpty = lock.newCondition();

    public BlockingQueueNew(int capacity) {
        this.capacity = capacity;
    }

    public void put(int element)  {
        lock.lock();
        try {
            while (queue.size() == capacity) {
				System.out.println("Queue is Full");
               notFull.await();

            }
            queue.add(element);
            notEmpty.signal();
        } finally {
            lock.unlock();
        }
    }

    public int take() {
        lock.lock();
        try {
            while (queue.isEmpty()) {
				System.out.println("Queue is Empty");
                notEmpty.await();
            }
            int item = queue.remove();
            notFull.signal();
            return item;
        } finally {
            lock.unlock();
        }
    }
	
	public static void main(String[] args){
		BlockingQueueNew BQ=new BlockingQueueNew(10);
		
		for(int i=1;i<12;i++){
			BQ.put(i);
		}
		for(int i=0;i<11;i++){
		System.out.println("Removed item is"+BQ.take());
		}
		
		
		
	}
}